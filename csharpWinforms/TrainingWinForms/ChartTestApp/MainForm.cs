using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartTestApp
{
    public partial class MainForm : MetroForm
    {
        readonly string strConnstring =
            "Data Source=127.0.0.1;Port=3306;Database=employees;Uid=root;Password=maria_p@ssw0rd!";
        readonly string strQuery = "SELECT  CONCAT(em.first_name, ' ', em.last_name) AS emp_Name, " +
                                   "        em.gender, " +
                                   "        em.hire_date, " +
                                   "        dp.dept_no, " +
                                   "        dt.dept_name, " +
                                   "        MAX(sl.salary) AS max_salary " +
                                   "   FROM employees AS em " +
                                   "  INNER JOIN dept_emp AS dp " +
                                   "     ON em.emp_no = dp.emp_no " +
                                   "  INNER JOIN departments AS dt " +
                                   "     ON dp.dept_no = dt.dept_no " +
                                   "  INNER JOIN salaries AS sl " +
                                   "     ON em.emp_no = sl.emp_no " +
                                   "  WHERE em.hire_date >= '2000-01-01' " +
                                   "  GROUP BY em.first_name, em.last_name, em.gender, em.hire_date, dt.dept_name " +
                                   "  ORDER BY em.first_name ASC ";

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnYValues_Click(object sender, EventArgs e)
        {
            ChtMain.Series[0].Points.Clear();
            ChtMain.Series[0].Points.Add(98);
            ChtMain.Series[0].Points.Add(72);
            ChtMain.Series[0].Points.Add(50);
            ChtMain.Series[0].Points.Add(100);
        }

        private void BtnXyValues_Click(object sender, EventArgs e)
        {
            ChtMain.Series[0].Points.Clear();
            ChtMain.Series[0].Points.AddXY(10, 98);
            ChtMain.Series[0].Points.AddXY(20, 72);
            ChtMain.Series[0].Points.AddXY(40, 50);
            ChtMain.Series[0].Points.AddXY(30, 100);

            //ChtMain.Series[0].ChartType = SeriesChartType.Line;
            //ChtMain.Series[0].ChartType = SeriesChartType.FastLine;
            //ChtMain.Series[0].ChartType = SeriesChartType.Spline;
            ChtMain.Series[0].ChartType = SeriesChartType.Area;
            //ChtMain.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            // Y값 배열 바인딩
            //double[] scores = new double[] { 80, 90, 85, 70, 95 };
            //ChtMain.Series[0].Points.DataBindY(scores);

            // X, Y값 List<T> 데이타바인딩
            //List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            //List<double> y = new List<double> { 80, 90, 85, 70, 95 };
            //ChtMain.Series[0].Points.DataBindXY(x, y);

            // 객체 컬렉션에 대한 데이타바인딩
            List<Student> students = new List<Student>();
            students.Add(new Student("철수", 80));
            students.Add(new Student("영희", 90));
            students.Add(new Student("길동", 85));
            students.Add(new Student("재동", 70));
            students.Add(new Student("민희", 95));
            // X축: Name, Y축: Score
            ChtMain.Series[0].Points.DataBind(students, "Name", "Score", null);
        }

        internal class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score)
            {
                Name = name;
                Score = score;
            }
        }

        /// <summary>
        /// DB 바인딩 버튼 클릭이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDbBinding_Click(object sender, EventArgs e)
        {
            #region DataBindTable

            // DataBindTableO() // 잘 안됨
            /* using (MySqlConnection conn = new MySqlConnection(strConnstring))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                ChtMain.DataBindTable(reader, "employees");
            } */

            #endregion

            #region DataSource & DataBind

            ChtMain.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            ChtMain.ChartAreas[0].AxisX.Title = "Employees";
            ChtMain.ChartAreas[0].AxisY.Title = "Max Salary";
            ChtMain.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep90;
            ChtMain.ChartAreas[0].AxisY.LabelStyle.Format = "${0,0}";

            ChtMain.Series[0].IsValueShownAsLabel = true;            
            ChtMain.Series[0].LabelFormat = "{0,0}";
            ChtMain.Series[0].Color = Color.Coral;

            using (MySqlConnection conn = new MySqlConnection(strConnstring))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                ChtMain.DataSource = ds.Tables[0];
                ChtMain.Series[0].XValueMember = "emp_Name";
                ChtMain.Series[0].YValueMembers = "max_salary";
                ChtMain.DataBind();
            }

            #endregion 
        }

        private void BtnMultiChart_Click(object sender, EventArgs e)
        {
            ChtMain.ChartAreas.Clear(); // cleanup before we start 
            ChtMain.Series.Clear(); 
            ChtMain.ChartAreas.Add("area1"); // 영역분리
            ChtMain.ChartAreas.Add("area2");
            
            ChtMain.Series.Add("series1");  // 시리즈 선언
            ChtMain.Series.Add("series2");
            ChtMain.Series.Add("series3");
             
            ChtMain.Series["series1"].ChartArea = "area1"; // 시리즈, 영역에 할당
            ChtMain.Series["series2"].ChartArea = "area2";
            ChtMain.Series["series3"].ChartArea = "area2";
            
            ChtMain.Series["series1"].ChartType = SeriesChartType.Spline;
            ChtMain.Series["series2"].ChartType = SeriesChartType.Spline;
            ChtMain.Series["series3"].ChartType = SeriesChartType.Spline;
            
            ChtMain.Series["series1"].Color = Color.Red;
            ChtMain.Series["series2"].Color = Color.Blue;
            ChtMain.Series["series3"].Color = Color.Green;
            
            ChtMain.Series["series1"].Points.AddXY(1, 100);
            ChtMain.Series["series1"].Points.AddXY(2, 400);
            ChtMain.Series["series1"].Points.AddXY(3, 200);
            ChtMain.Series["series1"].Points.AddXY(4, 300);

            ChtMain.Series["series2"].Points.AddXY(1, 120);
            ChtMain.Series["series2"].Points.AddXY(2, 420);
            ChtMain.Series["series2"].Points.AddXY(3, 290);
            ChtMain.Series["series2"].Points.AddXY(4, 390);

            ChtMain.Series["series3"].Points.AddXY(1, 220);
            ChtMain.Series["series3"].Points.AddXY(2, 320);
            ChtMain.Series["series3"].Points.AddXY(3, 690);
            ChtMain.Series["series3"].Points.AddXY(4, 190);

            ChtMain.Series["series3"].Points[1].Color = Color.HotPink; // 포인트별 색상설정
            ChtMain.Series["series3"].Points[2].Color = Color.Orange;
        }
    }
}
