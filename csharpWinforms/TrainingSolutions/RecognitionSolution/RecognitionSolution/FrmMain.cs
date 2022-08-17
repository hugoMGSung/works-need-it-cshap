using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Tesseract;

namespace RecognitionApp
{
    public partial class FrmMain : Form
    {
        private readonly VideoCapture capture;
        Mat frame = new Mat();

        public FrmMain()
        {
            InitializeComponent();

            capture = new VideoCapture();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            // 사이즈 조정
            capture.FrameWidth = 720; // 1280, 720
            capture.FrameHeight = 480; // 720, 480

            //ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            PbxCamera.ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);

            BgwVideo.RunWorkerAsync();
        }

        private void BgwVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                }
                Thread.Sleep(100);
            }
        }

        private void BgwVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            PbxCamera.Image?.Dispose();
            PbxCamera.Image = frameBitmap;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BgwVideo.CancelAsync();
            capture.Dispose();
        }

        private void BtnReconize_Click(object sender, EventArgs e)
        {
            SaveImage();
            ReconizeCarNumberPlate();
        }

        private void ReconizeCarNumberPlate()
        {
            // 
            //var mat = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)PbxCaptured.Image);
            var src = Cv2.ImRead($"./captured/{lastFileName}", ImreadModes.Grayscale);
            /*var binary = new Mat();
            Cv2.Threshold(src, binary, 150, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
            var noise = new Mat();
            Cv2.MedianBlur(binary, noise, ksize : 5);
            var edge = new Mat();
            Cv2.Canny(noise, edge, 0, 100);*/
            var edge = src.Canny(75, 200, 3, true);

            OpenCvSharp.Point testPoint = new OpenCvSharp.Point();
            OpenCvSharp.Point[][] contours0;
            HierarchyIndex[] hierarchies;
            InputArray ia;

            Cv2.FindContours(edge, out contours0, out hierarchies, RetrievalModes.External, 
                ContourApproximationModes.ApproxSimple, testPoint);
            // RetrievalModes.External 외곽선만 따거나, 내외곽선을 따는 옵션
            // 외곽선 검출한 좌표를 contours0 에 담음
            OpenCvSharp.Size cvsize;
            cvsize.Width = edge.Width;
            cvsize.Height = edge.Height;

            for (int i = 0; i < contours0.Length; i++)
            {
                double peri = Cv2.ArcLength(contours0[i], true);
                OpenCvSharp.Point[] pp = Cv2.ApproxPolyDP(contours0[i], 0.02 * peri, true);
                RotatedRect rrect = Cv2.MinAreaRect(pp);
                double areaRatio = Math.Abs(Cv2.ContourArea(contours0[i], false)) / (rrect.Size.Width * rrect.Size.Height);

                if (pp.Length == 4)
                {
                    Cv2.DrawContours(edge, contours0, i, Scalar.Red, 10, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                } 
            }

            ////OpenCvSharp.Point[] squares = Square(noise);
            //Mat square = DrawSquare(noise, squares);
            //Mat dst = PerspectiveTransform(noise, squares);
            PbxCaptured.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(edge);

            var ocr = new TesseractEngine("./traindata", "kor", EngineMode.Default);
            var result = ocr.Process((Bitmap)PbxCaptured.Image);
            if (result != null) TxtReqResult.Text = result.GetText();
        }

        public Mat PerspectiveTransform(Mat src, OpenCvSharp.Point[] squares)
        {
            Mat dst = new Mat();
            Moments moments = Cv2.Moments(squares);
            double cX = moments.M10 / moments.M00;
            double cY = moments.M01 / moments.M00;

            Point2f[] src_pts = new Point2f[4];
            for (int i = 0; i < squares.Length; i++)
            {
                if (cX > squares[i].X && cY > squares[i].Y) src_pts[0] = squares[i];
                if (cX > squares[i].X && cY < squares[i].Y) src_pts[1] = squares[i];
                if (cX < squares[i].X && cY > squares[i].Y) src_pts[2] = squares[i];
                if (cX < squares[i].X && cY < squares[i].Y) src_pts[3] = squares[i];
            }

            Point2f[] dst_pts = new Point2f[4]
            {
                new Point2f(0, 0),
                new Point2f(0, src.Height),
                new Point2f(src.Width, 0),
                new Point2f(src.Width, src.Height)
            };

            Mat matrix = Cv2.GetPerspectiveTransform(src_pts, dst_pts);
            Cv2.WarpPerspective(src, dst, matrix, new OpenCvSharp.Size(src.Width, src.Height));
            return dst;
        }

        public Mat DrawSquare(Mat src, OpenCvSharp.Point[] squares)
        {
            Mat drawsquare = src.Clone();
            OpenCvSharp.Point[][] pts = new OpenCvSharp.Point[][] { squares };
            Cv2.Polylines(drawsquare, pts, true, Scalar.Yellow, 3, LineTypes.AntiAlias, 0);
            return drawsquare;
        }

        public OpenCvSharp.Point[] Square(Mat src)
        {
            Mat[] split = Cv2.Split(src);
            Mat blur = new Mat();
            Mat binary = new Mat();
            OpenCvSharp.Point[] squares = new OpenCvSharp.Point[4];

            int N = 10;
            double max = src.Size().Width * src.Size().Height * 0.9;
            double min = src.Size().Width * src.Size().Height * 0.1;

            for (int channel = 0; channel < 3; channel++)
            {
                Cv2.GaussianBlur(split[channel], blur, new OpenCvSharp.Size(5, 5), 1);
                for (int i = 0; i < N; i++)
                {
                    Cv2.Threshold(blur, binary, i * 255 / N, 255, ThresholdTypes.Binary);

                    OpenCvSharp.Point[][] contours;
                    HierarchyIndex[] hierarchy;
                    Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxTC89KCOS);

                    Mat test = src.Clone();
                    Cv2.DrawContours(test, contours, -1, new Scalar(0, 0, 255), 3);

                    for (int j = 0; j < contours.Length; j++)
                    {
                        double perimeter = Cv2.ArcLength(contours[j], true);
                        OpenCvSharp.Point[] result = Cv2.ApproxPolyDP(contours[j], perimeter * 0.02, true);

                        double area = Cv2.ContourArea(result);
                        bool convex = Cv2.IsContourConvex(result);

                        if (result.Length == 4 && area > min && area < max && convex)
                        {
                            double cos = 0;
                            for (int k = 1; k < 5; k++)
                            {
                                double t = Math.Abs(Angle(result[(k - 1) % 4], result[k % 4], result[(k + 1) % 4]));
                                cos = cos > t ? cos : t;
                            }
                            if (cos < 0.15) squares = result;
                        }
                    }
                }
            }
            return squares;
        }

        private double Angle(OpenCvSharp.Point pt1, OpenCvSharp.Point pt0, OpenCvSharp.Point pt2)
        {
            double u1 = pt1.X - pt0.X;
            double u2 = pt1.Y - pt0.Y;
            double v1 = pt2.X - pt0.X;
            double v2 = pt2.Y - pt0.Y;

            return (u1 * v1 + u2 * v2) / (Math.Sqrt(u1 * u1 + u2 * u2) * Math.Sqrt(v1 * v1 + v2 * v2));
        }

        private string lastFileName = string.Empty;

        private void SaveImage()
        {
            string fileName = DateTime.Now.ToString("yyMMddhhMMssfffff");

            string folderPath = $@"{Application.StartupPath}\captured";
            DirectoryInfo di = new DirectoryInfo(folderPath);
            if (di.Exists == false) di.Create();

            lastFileName = $@"{fileName}.png";

            PbxCamera.Image.Save($@"{folderPath}\{lastFileName}", System.Drawing.Imaging.ImageFormat.Png);
            // Cv2.ImWrite($"./captured/{fileName}.png", capture);

            // 저장한 파일 로드하기
            Mat src = Cv2.ImRead($"./captured/{lastFileName}", ImreadModes.Color);
            PbxCaptured.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
            PbxCaptured.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
