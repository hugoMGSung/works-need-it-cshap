using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form1_Paint, 폼에 이미지 그리기 메서드
        /// created date : 2020.06.17.
        /// creator : personar95
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">페인트이벤트아규먼트</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            Pen pen = new Pen(Color.DeepPink);
            pen.Width = 6.8f;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //Point starPoint = new Point(45, 45);
            //Point endPoint = new Point(180, 150);
            //g.DrawLine(pen, starPoint, endPoint);
            //g.DrawLine(pen, 190, 60, 65, 170);

            // Rectangle rect = new Rectangle(50, 50, 100, 100);
            Rectangle[] rects = new Rectangle[]
            {
                new Rectangle(40,40,40,100),
                new Rectangle(100,40,100,40),
                new Rectangle(100,100,100,40),
            };
            g.FillRectangles(Brushes.BlueViolet, rects);
            g.DrawRectangles(pen, rects);

            Point[] pts =
            {
                new Point(515, 30), new Point(540, 90),
                new Point(600, 115), new Point(540, 140),
                new Point(515, 200), new Point(490, 140),
                new Point(430, 115), new Point(490, 90)
            };
            g.FillClosedCurve(Brushes.YellowGreen, pts);
            g.DrawClosedCurve(pen, pts);

        }
    }
}
