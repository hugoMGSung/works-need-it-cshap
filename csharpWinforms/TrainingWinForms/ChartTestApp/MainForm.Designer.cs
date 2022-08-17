namespace ChartTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnDbBinding = new MetroFramework.Controls.MetroButton();
            this.BtnData = new MetroFramework.Controls.MetroButton();
            this.BtnXyValues = new MetroFramework.Controls.MetroButton();
            this.BtnYValues = new MetroFramework.Controls.MetroButton();
            this.BtnMultiChart = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChtMain)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChtMain
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtMain.Legends.Add(legend1);
            this.ChtMain.Location = new System.Drawing.Point(23, 63);
            this.ChtMain.Name = "ChtMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.ChtMain.Series.Add(series1);
            this.ChtMain.Size = new System.Drawing.Size(880, 634);
            this.ChtMain.TabIndex = 0;
            this.ChtMain.Text = "chart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnMultiChart);
            this.metroPanel1.Controls.Add(this.BtnDbBinding);
            this.metroPanel1.Controls.Add(this.BtnData);
            this.metroPanel1.Controls.Add(this.BtnXyValues);
            this.metroPanel1.Controls.Add(this.BtnYValues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(909, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(348, 634);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnDbBinding
            // 
            this.BtnDbBinding.Location = new System.Drawing.Point(205, 260);
            this.BtnDbBinding.Name = "BtnDbBinding";
            this.BtnDbBinding.Size = new System.Drawing.Size(140, 50);
            this.BtnDbBinding.TabIndex = 2;
            this.BtnDbBinding.Text = "DB Binding";
            this.BtnDbBinding.UseSelectable = true;
            this.BtnDbBinding.Click += new System.EventHandler(this.BtnDbBinding_Click);
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(205, 128);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(140, 50);
            this.BtnData.TabIndex = 2;
            this.BtnData.Text = "List DATA";
            this.BtnData.UseSelectable = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnXyValues
            // 
            this.BtnXyValues.Location = new System.Drawing.Point(205, 59);
            this.BtnXyValues.Name = "BtnXyValues";
            this.BtnXyValues.Size = new System.Drawing.Size(140, 50);
            this.BtnXyValues.TabIndex = 2;
            this.BtnXyValues.Text = "XY Values";
            this.BtnXyValues.UseSelectable = true;
            this.BtnXyValues.Click += new System.EventHandler(this.BtnXyValues_Click);
            // 
            // BtnYValues
            // 
            this.BtnYValues.Location = new System.Drawing.Point(205, 3);
            this.BtnYValues.Name = "BtnYValues";
            this.BtnYValues.Size = new System.Drawing.Size(140, 50);
            this.BtnYValues.TabIndex = 2;
            this.BtnYValues.Text = "Only V Values";
            this.BtnYValues.UseSelectable = true;
            this.BtnYValues.Click += new System.EventHandler(this.BtnYValues_Click);
            // 
            // BtnMultiChart
            // 
            this.BtnMultiChart.Location = new System.Drawing.Point(205, 184);
            this.BtnMultiChart.Name = "BtnMultiChart";
            this.BtnMultiChart.Size = new System.Drawing.Size(140, 50);
            this.BtnMultiChart.TabIndex = 2;
            this.BtnMultiChart.Text = "Multi Chart";
            this.BtnMultiChart.UseSelectable = true;
            this.BtnMultiChart.Click += new System.EventHandler(this.BtnMultiChart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ChtMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Chart Test App";
            ((System.ComponentModel.ISupportInitialize)(this.ChtMain)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtMain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnXyValues;
        private MetroFramework.Controls.MetroButton BtnYValues;
        private MetroFramework.Controls.MetroButton BtnData;
        private MetroFramework.Controls.MetroButton BtnDbBinding;
        private MetroFramework.Controls.MetroButton BtnMultiChart;
    }
}

