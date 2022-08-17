using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TensorFlow;

namespace TensorflowTestApp
{
    public partial class FrmMain : Form
    {
        private string _modelFile = string.Empty;
        private string _labelFile = string.Empty;

        delegate void LogTextCallback(string message);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                DefaultExt = "png",
                Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp",
                Title = "Select Image",
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image sourceImage = Image.FromFile(dlg.FileName);
                Image targetImage = ResizeImage(sourceImage, this.PbxSelectImage.Size, Color.FromArgb(240, 240, 240));
                PbxSelectImage.Image = targetImage;

                TxtSelectImage.Text = dlg.FileName;
            }
        }

        private void ProcImageInference()
        {
            if (CheckModelFiles(Application.StartupPath))
            {
                var graph = new TFGraph();  // Construct an in-memory graph from the serialized form
                var model = File.ReadAllBytes(_modelFile); // Load the serialized GraphDef from a file

                graph.Import(model);

                using (TFSession session = new TFSession(graph))
                {
                    var labels = File.ReadAllLines(_labelFile);
                    var tensor = CreateTensorFromImageFile(TxtSelectImage.Text);
                    var runner = session.GetRunner();

                    runner.AddInput(graph["input"][0], tensor).Fetch(graph["output"][0]);
                    //runner.AddInput(graph["input"][0], tensor).Fetch(graph["InceptionV1/Logits/Predictions/Softmax"][0]);
                    TFTensor result = runner.Run()[0];
                    var resultShape = result.Shape;
                    if (result.NumDims != 2 || resultShape[0] != 1)
                    {
                        var shape = string.Empty;
                        foreach (var item in resultShape)
                        {
                            shape += $"{item} ";
                        }
                        shape = shape.Trim();
                        LogText($"Error: expected to produce a [1 N] shaped tensor where N is the number of labels, instead it produced one with shape [{shape}]");

                        return;
                    }

                    bool jagged = true;
                    var bestIndex = 0;
                    float best = 0;

                    if (jagged)
                    {
                        var probabilities = ((float[][])result.GetValue(jagged: true))[0];
                        for (int i = 0; i < probabilities.Length; i++)
                        {
                            if (probabilities[i] > best)
                            {
                                bestIndex = i;
                                best = probabilities[i];
                            }
                        }
                    }
                    else
                    {
                        var val = (float[,])result.GetValue(jagged: false);

                        // Result is [1,N], flatten array
                        for (int i = 0; i < val.GetLength(1); i++)
                        {
                            if (val[0, i] > best)
                            {
                                bestIndex = i;
                                best = val[0, i];
                            }
                        }
                    }

                    LogText($"best match: [{bestIndex}] {best * 100.0}% {labels[bestIndex]}");
                }
            }
        }

        private void LogText(string message)
        {
            if (RtbLogs.InvokeRequired)
            {
                LogTextCallback d = new LogTextCallback(LogText);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.RtbLogs.AppendText(message + "\n");
                this.RtbLogs.ScrollToCaret();
            }
        }

        private bool CheckModelFiles(string path)
        {
            _modelFile = Path.Combine(path, "model", "tensorflow_inception_graph.pb");
            _labelFile = Path.Combine(path, "model", "imagenet_comp_graph_label_strings.txt");

            if (File.Exists(_modelFile) && File.Exists(_labelFile))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        // Convert the image in filename to a Tensor suitable as input to the Inception model.
        public TFTensor CreateTensorFromImageFile(string file, TFDataType destinationDataType = TFDataType.Float)
        {
            var contents = File.ReadAllBytes(file);

            // DecodeJpeg uses a scalar String-valued tensor as input.
            var tensor = TFTensor.CreateString(contents);

            TFOutput input, output;

            // Construct a graph to normalize the image
            using (var graph = ConstructGraphToNormalizeImage(out input, out output, destinationDataType))
            {
                // Execute that graph to normalize this one image
                using (var session = new TFSession(graph))
                {
                    var normalized = session.Run(
                        inputs: new[] { input },
                        inputValues: new[] { tensor },
                        outputs: new[] { output });

                    return normalized[0];
                }
            }
        }

        // The inception model takes as input the image described by a Tensor in a very
        // specific normalized format (a particular image size, shape of the input tensor,
        // normalized pixel values etc.).
        //
        // This function constructs a graph of TensorFlow operations which takes as
        // input a JPEG-encoded string and returns a tensor suitable as input to the
        // inception model.
        private TFGraph ConstructGraphToNormalizeImage(out TFOutput input, out TFOutput output, TFDataType destinationDataType = TFDataType.Float)
        {
            // Some constants specific to the pre-trained model at:
            // https://storage.googleapis.com/download.tensorflow.org/models/inception5h.zip
            //
            // - The model was trained after with images scaled to 224x224 pixels.
            // - The colors, represented as R, G, B in 1-byte each were converted to
            //   float using (value - Mean)/Scale.

            const int W = 224;
            const int H = 224;
            const float Mean = 0.5f;
            const float Scale = 2.0f;

            var graph = new TFGraph();
            input = graph.Placeholder(TFDataType.String);

            var scale = graph.Div(
                    x: graph.Const(1.0f),
                    y: graph.Const(255.0f)
                    );

            output = graph.Mul(
                x: graph.Sub(
                    x: graph.Squeeze(
                        input: graph.ResizeBilinear(
                            images: graph.ExpandDims(
                                input: graph.Mul(
                                        x: graph.Cast(graph.DecodeJpeg(contents: input, channels: 3), DstT: TFDataType.Float),
                                        y: scale),
                                dim: graph.Const(0, "make_batch")),
                            size: graph.Const(new int[] { W, H }, "size"),
                            align_corners: false),
                        squeeze_dims: new long[] { 0 }),
                    y: graph.Const(Mean, "mean")),
                y: graph.Const(Scale, "scale"));

            output = graph.ExpandDims(
                input: output,
                dim: graph.Const(0));


            //output = graph.Cast(graph.Div(
            //    x: graph.Sub(
            //        x: graph.ResizeBilinear(
            //            images: graph.ExpandDims(
            //                input: graph.Cast(
            //                    graph.DecodeJpeg(contents: input, channels: 3), DstT: TFDataType.Float),
            //                dim: graph.Const(0, "make_batch")),
            //            size: graph.Const(new int[] { W, H }, "size")),
            //        y: graph.Const(Mean, "mean")),
            //    y: graph.Const(Scale, "scale")), destinationDataType);


            //output = graph.Mul(
            //    x: graph.Sub(
            //        x: graph.Mul(
            //            x: graph.Cast( 
            //                graph.DecodeJpeg(contents: input, channels: 3), DstT: TFDataType.Float),
            //            y: scale),
            //        y: graph.Const(Mean, "mean")),
            //    y: graph.Const(Scale, "scale"));



            return graph;
        }

        private void BtnStartProcess_Click(object sender, EventArgs e)
        {
            ProcImageInference();
        }

        public Image ResizeImage(Image sourceImage, Size targetSize, Color backgroundColor, bool isImageCenterAligned = true)
        {
            if (sourceImage == null || targetSize == Size.Empty)
            {
                return null;
            }

            int sourceWidth = sourceImage.Size.Width;
            int sourceHeight = sourceImage.Size.Height;
            int targetWidth = targetSize.Width;
            int targetHeight = targetSize.Height;

            Image targetImage = new Bitmap(targetWidth, targetHeight);
            Graphics targetGraphics = Graphics.FromImage(targetImage);

            targetGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            targetGraphics.SmoothingMode = SmoothingMode.HighQuality;
            targetGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            targetGraphics.CompositingQuality = CompositingQuality.HighQuality;

            double ratioX = (double)targetWidth / (double)sourceWidth;
            double ratioY = (double)targetHeight / (double)sourceHeight;
            double ratio = ratioX < ratioY ? ratioX : ratioY;

            int newHeight = Convert.ToInt32(sourceHeight * ratio);
            int newWidth = Convert.ToInt32(sourceWidth * ratio);

            int positionX = Convert.ToInt32((targetWidth - (sourceImage.Width * ratio)) / 2);
            int positionY = Convert.ToInt32((targetHeight - (sourceImage.Height * ratio)) / 2);

            if (!isImageCenterAligned)
            {
                positionX = 0;
                positionY = 0;
            }

            targetGraphics.Clear(backgroundColor);
            targetGraphics.DrawImage(sourceImage, positionX, positionY, newWidth, newHeight);
            ImageCodecInfo[] imageCodecInfoArray = ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
            
            Stream stream = new MemoryStream();
            targetImage.Save(stream, imageCodecInfoArray[1], encoderParameters);

            return Image.FromStream(stream);
        }
    }
}
