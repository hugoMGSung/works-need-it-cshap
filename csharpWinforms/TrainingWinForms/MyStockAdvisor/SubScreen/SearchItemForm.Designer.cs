namespace MyStockAdvisor
{
    partial class SearchItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchItemForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.DgvStocks = new System.Windows.Forms.DataGridView();
            this.ISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSUDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KORSECNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECNKACDNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHOTNISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
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
            this.metroTabPage1.Text = "주식기조정보수집";
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
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
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
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.Location = new System.Drawing.Point(856, 6);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(250, 30);
            this.TxtSearchItem.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchItem.TabIndex = 0;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // DgvStocks
            // 
            this.DgvStocks.AllowUserToAddRows = false;
            this.DgvStocks.AllowUserToDeleteRows = false;
            this.DgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISIN,
            this.ISSUDT,
            this.KORSECNAME,
            this.SECNKACDNM,
            this.SHOTNISIN});
            this.DgvStocks.Location = new System.Drawing.Point(3, 3);
            this.DgvStocks.Name = "DgvStocks";
            this.DgvStocks.ReadOnly = true;
            this.DgvStocks.RowHeadersWidth = 45;
            this.DgvStocks.RowTemplate.Height = 24;
            this.DgvStocks.Size = new System.Drawing.Size(1214, 494);
            this.DgvStocks.TabIndex = 0;
            // 
            // ISIN
            // 
            this.ISIN.HeaderText = "표준코드";
            this.ISIN.MinimumWidth = 6;
            this.ISIN.Name = "ISIN";
            this.ISIN.ReadOnly = true;
            this.ISIN.Width = 150;
            // 
            // ISSUDT
            // 
            this.ISSUDT.HeaderText = "주식발행일자";
            this.ISSUDT.MinimumWidth = 6;
            this.ISSUDT.Name = "ISSUDT";
            this.ISSUDT.ReadOnly = true;
            this.ISSUDT.Width = 200;
            // 
            // KORSECNAME
            // 
            this.KORSECNAME.HeaderText = "한글종목명";
            this.KORSECNAME.MinimumWidth = 6;
            this.KORSECNAME.Name = "KORSECNAME";
            this.KORSECNAME.ReadOnly = true;
            this.KORSECNAME.Width = 300;
            // 
            // SECNKACDNM
            // 
            this.SECNKACDNM.HeaderText = "보통주/우선주";
            this.SECNKACDNM.MinimumWidth = 6;
            this.SECNKACDNM.Name = "SECNKACDNM";
            this.SECNKACDNM.ReadOnly = true;
            this.SECNKACDNM.Width = 250;
            // 
            // SHOTNISIN
            // 
            this.SHOTNISIN.HeaderText = "단축코드";
            this.SHOTNISIN.MinimumWidth = 6;
            this.SHOTNISIN.Name = "SHOTNISIN";
            this.SHOTNISIN.ReadOnly = true;
            this.SHOTNISIN.Width = 150;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "해당정보수집";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
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
            // SearchItemForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlBack);
            this.Font = new System.Drawing.Font("나눔고딕", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchItemForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "종목 검색";
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
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private System.Windows.Forms.DataGridView DgvStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSUDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KORSECNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECNKACDNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHOTNISIN;
    }
}

