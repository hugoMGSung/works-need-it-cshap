using OpenCvSharp;
using System;
using System.Windows.Forms;
using Tesseract;

namespace ImageViewer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Mat src = Cv2.ImRead("cat.jpg", ImreadModes.Color);
            var cnvImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
            this.ClientSize = new System.Drawing.Size(cnvImage.Width, cnvImage.Height);
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
            // new TesseractEngine("./traindata", "eng", EngineMode.TesseractOnly);
            var ocr = new TesseractEngine("./traindata", "kor", EngineMode.TesseractOnly);
            var texts = ocr.Process(cnvImage);
            //MessageBox.Show(texts.GetText());

            // Gray
            /*Mat dst = new Mat(src.Size(), MatType.CV_8UC1);
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY);
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);*/

            // 전환
            /*dst = new Mat(src.Size(), MatType.CV_8UC3);
            Cv2.Flip(src, dst, FlipMode.Y);
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);*/

            // 축소
            Mat dstDown = new Mat();
            Cv2.PyrDown(src, dstDown);
            Cv2.ImShow("PyrDown", dstDown);
            // Cv2를 통해서 새로운 창을 열어서 처리

            // 이진화
            /*Mat gray = new Mat();
            Mat binary = new Mat();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(gray, binary, 150, 255, ThresholdTypes.Binary);
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(binary);*/

            // 역상
            /*Mat reverse = new Mat();
            Cv2.BitwiseNot(src, reverse);
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(reverse);*/

            // Blur
            /*Mat blur = new Mat();
            Cv2.Blur(src, blur, new Size(5, 5));
            PbxResult.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(blur);*/


        }
    }
}
