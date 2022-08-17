namespace MyStockAdvisor
{
    partial class GalmetgilCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalmetgilCourseForm));
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.DgvStocks = new System.Windows.Forms.DataGridView();
            this.kosNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // MtlBack
            // 
            this.MtlBack.Location = new System.Drawing.Point(1197, 657);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(60, 40);
            this.MtlBack.TabIndex = 2;
            this.MtlBack.TileImage = global::MyStockAdvisor.Properties.Resources.back2;
            this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.UseTileImage = true;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1234, 588);
            this.metroTabControl1.TabIndex = 3;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "정보조회";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.DgvStocks);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 545);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1112, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(105, 35);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "조회";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvStocks
            // 
            this.DgvStocks.AllowUserToAddRows = false;
            this.DgvStocks.AllowUserToDeleteRows = false;
            this.DgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kosNm,
            this.kosType,
            this.kosTxt,
            this.img,
            this.txt1,
            this.title,
            this.txt2});
            this.DgvStocks.Location = new System.Drawing.Point(3, 3);
            this.DgvStocks.Name = "DgvStocks";
            this.DgvStocks.ReadOnly = true;
            this.DgvStocks.RowHeadersWidth = 45;
            this.DgvStocks.RowTemplate.Height = 24;
            this.DgvStocks.Size = new System.Drawing.Size(1214, 494);
            this.DgvStocks.TabIndex = 0;
            this.DgvStocks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStocks_CellDoubleClick);
            // 
            // kosNm
            // 
            this.kosNm.HeaderText = "코스명";
            this.kosNm.MinimumWidth = 6;
            this.kosNm.Name = "kosNm";
            this.kosNm.ReadOnly = true;
            this.kosNm.Width = 90;
            // 
            // kosType
            // 
            this.kosType.HeaderText = "코스종류";
            this.kosType.MinimumWidth = 6;
            this.kosType.Name = "kosType";
            this.kosType.ReadOnly = true;
            this.kosType.Width = 200;
            // 
            // kosTxt
            // 
            this.kosTxt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kosTxt.HeaderText = "상세코스";
            this.kosTxt.MinimumWidth = 6;
            this.kosTxt.Name = "kosTxt";
            this.kosTxt.ReadOnly = true;
            this.kosTxt.Width = 109;
            // 
            // img
            // 
            this.img.HeaderText = "이미지";
            this.img.MinimumWidth = 6;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 250;
            // 
            // txt1
            // 
            this.txt1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt1.HeaderText = "소요시간";
            this.txt1.MinimumWidth = 6;
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Width = 109;
            // 
            // title
            // 
            this.title.HeaderText = "타이틀";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 110;
            // 
            // txt2
            // 
            this.txt2.HeaderText = "레벨";
            this.txt2.MinimumWidth = 6;
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Width = 80;
            // 
            // GalmetgilCourseForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlBack);
            this.Font = new System.Drawing.Font("나눔고딕", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GalmetgilCourseForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "갈맷길코스 조회";
            this.Load += new System.EventHandler(this.SearchItemForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton BtnSearchItem;
        private MetroFramework.Controls.MetroTile MtlBack;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private System.Windows.Forms.DataGridView DgvStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt2;
    }
}

