
namespace WinChartApp
{
    partial class FrmThirdChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChtMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtMain
            // 
            chartArea2.Name = "ChartArea1";
            this.ChtMain.ChartAreas.Add(chartArea2);
            this.ChtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChtMain.Legends.Add(legend2);
            this.ChtMain.Location = new System.Drawing.Point(0, 0);
            this.ChtMain.Name = "ChtMain";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChtMain.Series.Add(series2);
            this.ChtMain.Size = new System.Drawing.Size(655, 449);
            this.ChtMain.TabIndex = 0;
            this.ChtMain.Text = "chart1";
            // 
            // FrmThirdChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 449);
            this.Controls.Add(this.ChtMain);
            this.Name = "FrmThirdChart";
            this.Text = "FrmThirdChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThirdChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChtMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtMain;
    }
}