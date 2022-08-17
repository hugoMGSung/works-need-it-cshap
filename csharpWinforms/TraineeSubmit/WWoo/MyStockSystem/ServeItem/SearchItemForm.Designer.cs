namespace MyStockSystem
{
    partial class SearchItemForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.ISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSUDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KORSECNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECNKACDNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHOTNISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Mtltxt = new MetroFramework.Controls.MetroTextBox();
            this.MtlSearch = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISIN,
            this.ISSUDT,
            this.KORSECNAME,
            this.SECNKACDNM,
            this.SHOTNISIN});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(846, 368);
            this.DGV.TabIndex = 3;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISIN
            // 
            this.ISIN.HeaderText = "종목번호";
            this.ISIN.Name = "ISIN";
            this.ISIN.Width = 160;
            // 
            // ISSUDT
            // 
            this.ISSUDT.HeaderText = "발행일";
            this.ISSUDT.Name = "ISSUDT";
            this.ISSUDT.Width = 160;
            // 
            // KORSECNAME
            // 
            this.KORSECNAME.HeaderText = "한글 종목명";
            this.KORSECNAME.Name = "KORSECNAME";
            this.KORSECNAME.Width = 160;
            // 
            // SECNKACDNM
            // 
            this.SECNKACDNM.HeaderText = "주식종류";
            this.SECNKACDNM.Name = "SECNKACDNM";
            this.SECNKACDNM.Width = 160;
            // 
            // SHOTNISIN
            // 
            this.SHOTNISIN.HeaderText = "단축코드";
            this.SHOTNISIN.Name = "SHOTNISIN";
            this.SHOTNISIN.Width = 160;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(854, 468);
            this.metroTabControl1.TabIndex = 5;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer2);
            this.metroTabPage1.Font = new System.Drawing.Font("HY견명조", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(846, 428);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "주식기초정보수집";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel1.Controls.Add(this.Mtltxt);
            this.splitContainer2.Panel1.Controls.Add(this.MtlSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DGV);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.splitContainer2.Size = new System.Drawing.Size(846, 428);
            this.splitContainer2.SplitterDistance = 56;
            this.splitContainer2.TabIndex = 2;
            // 
            // Mtltxt
            // 
            this.Mtltxt.Location = new System.Drawing.Point(467, 3);
            this.Mtltxt.Name = "Mtltxt";
            this.Mtltxt.Size = new System.Drawing.Size(265, 44);
            this.Mtltxt.TabIndex = 1;
            this.Mtltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mtltxt_KeyPress);
            // 
            // MtlSearch
            // 
            this.MtlSearch.Location = new System.Drawing.Point(738, 3);
            this.MtlSearch.Name = "MtlSearch";
            this.MtlSearch.Size = new System.Drawing.Size(105, 44);
            this.MtlSearch.TabIndex = 0;
            this.MtlSearch.Text = "Search";
            this.MtlSearch.Click += new System.EventHandler(this.MtlSearch_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Font = new System.Drawing.Font("HY견고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(846, 428);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "해당정보수집";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // MtlBack
            // 
            this.MtlBack.Location = new System.Drawing.Point(807, 537);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(70, 40);
            this.MtlBack.TabIndex = 4;
            this.MtlBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MtlBack.TileImage = global::MyStockSystem.Properties.Resources.back2;
            this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlBack.UseTileImage = true;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.MtlBack);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchItemForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "종목 검색";
            this.Load += new System.EventHandler(this.SearchItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV;
        private MetroFramework.Controls.MetroTile MtlBack;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroTextBox Mtltxt;
        private MetroFramework.Controls.MetroButton MtlSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSUDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KORSECNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECNKACDNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHOTNISIN;
    }
}