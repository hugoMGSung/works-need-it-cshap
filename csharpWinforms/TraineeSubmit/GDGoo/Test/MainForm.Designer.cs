namespace Test
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SearchText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.countryNmae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryEnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.CountryInfo = new MetroFramework.Controls.MetroTabPage();
            this.tBasic = new MetroFramework.Controls.MetroLabel();
            this.tCountryEnName = new MetroFramework.Controls.MetroLabel();
            this.tContinent = new MetroFramework.Controls.MetroLabel();
            this.tCountryNmae = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CountryImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.Tab.SuspendLayout();
            this.CountryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SearchText);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.DataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tab);
            this.splitContainer1.Panel2.Controls.Add(this.CountryImage);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 640);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 0;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(111, 3);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(260, 23);
            this.SearchText.TabIndex = 4;
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "국가명 :";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(377, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryNmae,
            this.countryEnName,
            this.continent});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.Location = new System.Drawing.Point(0, 29);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 23;
            this.DataGrid.Size = new System.Drawing.Size(455, 611);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // countryNmae
            // 
            this.countryNmae.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryNmae.FillWeight = 180F;
            this.countryNmae.HeaderText = "국가명";
            this.countryNmae.Name = "countryNmae";
            // 
            // countryEnName
            // 
            this.countryEnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryEnName.FillWeight = 300F;
            this.countryEnName.HeaderText = "영문 국가명";
            this.countryEnName.Name = "countryEnName";
            // 
            // continent
            // 
            this.continent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.continent.FillWeight = 180F;
            this.continent.HeaderText = "대륙";
            this.continent.Name = "continent";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.CountryInfo);
            this.Tab.Location = new System.Drawing.Point(3, 160);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(775, 477);
            this.Tab.TabIndex = 2;
            // 
            // CountryInfo
            // 
            this.CountryInfo.Controls.Add(this.tBasic);
            this.CountryInfo.Controls.Add(this.tCountryEnName);
            this.CountryInfo.Controls.Add(this.tContinent);
            this.CountryInfo.Controls.Add(this.tCountryNmae);
            this.CountryInfo.Controls.Add(this.metroLabel3);
            this.CountryInfo.Controls.Add(this.metroLabel4);
            this.CountryInfo.Controls.Add(this.metroLabel2);
            this.CountryInfo.Controls.Add(this.metroTile3);
            this.CountryInfo.Controls.Add(this.metroTile2);
            this.CountryInfo.Controls.Add(this.metroTile1);
            this.CountryInfo.HorizontalScrollbarBarColor = true;
            this.CountryInfo.Location = new System.Drawing.Point(4, 36);
            this.CountryInfo.Name = "CountryInfo";
            this.CountryInfo.Size = new System.Drawing.Size(767, 437);
            this.CountryInfo.TabIndex = 0;
            this.CountryInfo.Text = "국가 기본 정보";
            this.CountryInfo.VerticalScrollbarBarColor = true;
            // 
            // tBasic
            // 
            this.tBasic.AutoSize = true;
            this.tBasic.Location = new System.Drawing.Point(35, 191);
            this.tBasic.Name = "tBasic";
            this.tBasic.Size = new System.Drawing.Size(0, 0);
            this.tBasic.TabIndex = 9;
            // 
            // tCountryEnName
            // 
            this.tCountryEnName.AutoSize = true;
            this.tCountryEnName.Location = new System.Drawing.Point(60, 89);
            this.tCountryEnName.Name = "tCountryEnName";
            this.tCountryEnName.Size = new System.Drawing.Size(0, 0);
            this.tCountryEnName.TabIndex = 9;
            // 
            // tContinent
            // 
            this.tContinent.AutoSize = true;
            this.tContinent.Location = new System.Drawing.Point(392, 57);
            this.tContinent.Name = "tContinent";
            this.tContinent.Size = new System.Drawing.Size(0, 0);
            this.tContinent.TabIndex = 9;
            // 
            // tCountryNmae
            // 
            this.tCountryNmae.AutoSize = true;
            this.tCountryNmae.Location = new System.Drawing.Point(60, 57);
            this.tCountryNmae.Name = "tCountryNmae";
            this.tCountryNmae.Size = new System.Drawing.Size(0, 0);
            this.tCountryNmae.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "영 :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(342, 57);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "대륙 :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "한 :";
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(12, 149);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(75, 23);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "국가 정보";
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(323, 20);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 23);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "국가 위치";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(12, 20);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "국가명";
            // 
            // CountryImage
            // 
            this.CountryImage.Location = new System.Drawing.Point(31, 29);
            this.CountryImage.Name = "CountryImage";
            this.CountryImage.Size = new System.Drawing.Size(164, 106);
            this.CountryImage.TabIndex = 0;
            this.CountryImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "국가별 정보";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.Tab.ResumeLayout(false);
            this.CountryInfo.ResumeLayout(false);
            this.CountryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DataGrid;
        private MetroFramework.Controls.MetroTextBox SearchText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNmae;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryEnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn continent;
        private System.Windows.Forms.PictureBox CountryImage;
        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage CountryInfo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel tBasic;
        private MetroFramework.Controls.MetroLabel tCountryEnName;
        private MetroFramework.Controls.MetroLabel tContinent;
        private MetroFramework.Controls.MetroLabel tCountryNmae;
    }
}

