namespace thursday.TradeFigure
{
    partial class TradeFigureForm
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.지역코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.법정동 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.아파트 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.건축년도 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전용면적 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.층 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.년 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.월 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.도로명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지번 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(1091, 768);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(161, 141);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.TileImage = global::thursday.Properties.Resources.icon__5_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.지역코드,
            this.법정동,
            this.아파트,
            this.건축년도,
            this.거래금액,
            this.전용면적,
            this.층,
            this.년,
            this.월,
            this.일,
            this.도로명,
            this.지번});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(23, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 695);
            this.dataGridView1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.metroTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(587, 41);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "지역코드";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(3, 3);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(278, 35);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "년월";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(3, 3);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(294, 35);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(627, 20);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(161, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Search";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // 지역코드
            // 
            this.지역코드.HeaderText = "지역코드";
            this.지역코드.Name = "지역코드";
            this.지역코드.Width = 80;
            // 
            // 법정동
            // 
            this.법정동.HeaderText = "법정동";
            this.법정동.Name = "법정동";
            this.법정동.Width = 80;
            // 
            // 아파트
            // 
            this.아파트.HeaderText = "아파트";
            this.아파트.Name = "아파트";
            this.아파트.Width = 120;
            // 
            // 건축년도
            // 
            this.건축년도.HeaderText = "건축년도";
            this.건축년도.Name = "건축년도";
            this.건축년도.Width = 80;
            // 
            // 거래금액
            // 
            this.거래금액.HeaderText = "거래금액(단위:만원)";
            this.거래금액.Name = "거래금액";
            this.거래금액.Width = 150;
            // 
            // 전용면적
            // 
            this.전용면적.HeaderText = "전용면적";
            this.전용면적.Name = "전용면적";
            this.전용면적.Width = 80;
            // 
            // 층
            // 
            this.층.HeaderText = "층";
            this.층.Name = "층";
            // 
            // 년
            // 
            this.년.HeaderText = "년";
            this.년.Name = "년";
            // 
            // 월
            // 
            this.월.HeaderText = "월";
            this.월.Name = "월";
            // 
            // 일
            // 
            this.일.HeaderText = "일";
            this.일.Name = "일";
            // 
            // 도로명
            // 
            this.도로명.HeaderText = "도로명";
            this.도로명.Name = "도로명";
            this.도로명.Width = 90;
            // 
            // 지번
            // 
            this.지번.HeaderText = "지번";
            this.지번.Name = "지번";
            // 
            // TradeFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroTile1);
            this.Name = "TradeFigureForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TradeFigureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지역코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 법정동;
        private System.Windows.Forms.DataGridViewTextBoxColumn 아파트;
        private System.Windows.Forms.DataGridViewTextBoxColumn 건축년도;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전용면적;
        private System.Windows.Forms.DataGridViewTextBoxColumn 층;
        private System.Windows.Forms.DataGridViewTextBoxColumn 년;
        private System.Windows.Forms.DataGridViewTextBoxColumn 월;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 도로명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지번;
    }
}