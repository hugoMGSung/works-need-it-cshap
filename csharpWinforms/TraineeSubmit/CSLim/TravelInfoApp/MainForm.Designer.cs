namespace TravelInfoApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.GrdCountry = new MetroFramework.Controls.MetroGrid();
            this.countryEnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgBox = new System.Windows.Forms.FlowLayoutPanel();
            this.ImgCountry = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDeath = new System.Windows.Forms.Label();
            this.TxtDecide = new System.Windows.Forms.Label();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.LbData = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplitContainer)).BeginInit();
            this.LeftSplitContainer.Panel1.SuspendLayout();
            this.LeftSplitContainer.Panel2.SuspendLayout();
            this.LeftSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCountry)).BeginInit();
            this.ImgBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(20, 60);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.LeftSplitContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainSplitContainer.Panel2.Controls.Add(this.ImgBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.label3);
            this.MainSplitContainer.Panel2.Controls.Add(this.label1);
            this.MainSplitContainer.Panel2.Controls.Add(this.TxtRate);
            this.MainSplitContainer.Panel2.Controls.Add(this.label4);
            this.MainSplitContainer.Panel2.Controls.Add(this.TxtDeath);
            this.MainSplitContainer.Panel2.Controls.Add(this.TxtDecide);
            this.MainSplitContainer.Panel2.Controls.Add(this.metroTile2);
            this.MainSplitContainer.Panel2.Controls.Add(this.metroTile3);
            this.MainSplitContainer.Panel2.Controls.Add(this.metroTile1);
            this.MainSplitContainer.Panel2.Controls.Add(this.LbData);
            this.MainSplitContainer.Size = new System.Drawing.Size(1240, 640);
            this.MainSplitContainer.SplitterDistance = 413;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // LeftSplitContainer
            // 
            this.LeftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.LeftSplitContainer.Name = "LeftSplitContainer";
            this.LeftSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LeftSplitContainer.Panel1
            // 
            this.LeftSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LeftSplitContainer.Panel1.Controls.Add(this.BtnSearch);
            this.LeftSplitContainer.Panel1.Controls.Add(this.TxtSearch);
            // 
            // LeftSplitContainer.Panel2
            // 
            this.LeftSplitContainer.Panel2.Controls.Add(this.GrdCountry);
            this.LeftSplitContainer.Size = new System.Drawing.Size(413, 640);
            this.LeftSplitContainer.SplitterDistance = 30;
            this.LeftSplitContainer.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(320, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(80, 25);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(14, 3);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.ShortcutsEnabled = true;
            this.TxtSearch.Size = new System.Drawing.Size(300, 25);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // GrdCountry
            // 
            this.GrdCountry.AllowUserToResizeRows = false;
            this.GrdCountry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrdCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdCountry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdCountry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCountry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryEnName,
            this.countryName,
            this.continent,
            this.basic,
            this.imgUrl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdCountry.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCountry.EnableHeadersVisualStyles = false;
            this.GrdCountry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdCountry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrdCountry.Location = new System.Drawing.Point(0, 0);
            this.GrdCountry.Name = "GrdCountry";
            this.GrdCountry.ReadOnly = true;
            this.GrdCountry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCountry.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdCountry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdCountry.RowTemplate.Height = 23;
            this.GrdCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCountry.Size = new System.Drawing.Size(413, 606);
            this.GrdCountry.TabIndex = 0;
            this.GrdCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCountry_CellClick);
            // 
            // countryEnName
            // 
            this.countryEnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryEnName.HeaderText = "영문국가명";
            this.countryEnName.Name = "countryEnName";
            this.countryEnName.ReadOnly = true;
            // 
            // countryName
            // 
            this.countryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryName.HeaderText = "국가명";
            this.countryName.Name = "countryName";
            this.countryName.ReadOnly = true;
            // 
            // continent
            // 
            this.continent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.continent.HeaderText = "대륙";
            this.continent.Name = "continent";
            this.continent.ReadOnly = true;
            // 
            // basic
            // 
            this.basic.HeaderText = "정보";
            this.basic.Name = "basic";
            this.basic.ReadOnly = true;
            this.basic.Visible = false;
            // 
            // imgUrl
            // 
            this.imgUrl.HeaderText = "국기 이미지";
            this.imgUrl.Name = "imgUrl";
            this.imgUrl.ReadOnly = true;
            this.imgUrl.Visible = false;
            // 
            // ImgBox
            // 
            this.ImgBox.BackColor = System.Drawing.Color.Black;
            this.ImgBox.Controls.Add(this.ImgCountry);
            this.ImgBox.Location = new System.Drawing.Point(5, 476);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(282, 162);
            this.ImgBox.TabIndex = 5;
            this.ImgBox.Visible = false;
            // 
            // ImgCountry
            // 
            this.ImgCountry.BackColor = System.Drawing.Color.White;
            this.ImgCountry.Location = new System.Drawing.Point(1, 1);
            this.ImgCountry.Margin = new System.Windows.Forms.Padding(1);
            this.ImgCountry.Name = "ImgCountry";
            this.ImgCountry.Size = new System.Drawing.Size(280, 160);
            this.ImgCountry.TabIndex = 4;
            this.ImgCountry.TabStop = false;
            this.ImgCountry.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(412, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "확진자 수 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(412, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "사망자 수 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtRate
            // 
            this.TxtRate.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.TxtRate.Location = new System.Drawing.Point(527, 588);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(149, 30);
            this.TxtRate.TabIndex = 3;
            this.TxtRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(412, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "사망 비율 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDeath
            // 
            this.TxtDeath.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDeath.Location = new System.Drawing.Point(527, 540);
            this.TxtDeath.Name = "TxtDeath";
            this.TxtDeath.Size = new System.Drawing.Size(149, 30);
            this.TxtDeath.TabIndex = 3;
            this.TxtDeath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDecide
            // 
            this.TxtDecide.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDecide.Location = new System.Drawing.Point(527, 491);
            this.TxtDecide.Name = "TxtDecide";
            this.TxtDecide.Size = new System.Drawing.Size(149, 30);
            this.TxtDecide.TabIndex = 3;
            this.TxtDecide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile2.Location = new System.Drawing.Point(3, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(817, 48);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "   국가 정보 (글 더블 클릭시 확대)";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.Teal;
            this.metroTile3.Location = new System.Drawing.Point(5, 422);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(282, 48);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "   국기";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile1.Location = new System.Drawing.Point(386, 422);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(434, 48);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "   코로나 정보";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LbData.Location = new System.Drawing.Point(5, 58);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(0, 0);
            this.LbData.TabIndex = 0;
            this.LbData.DoubleClick += new System.EventHandler(this.LbData_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "해외 국가 정보 시스템";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.LeftSplitContainer.Panel1.ResumeLayout(false);
            this.LeftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplitContainer)).EndInit();
            this.LeftSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCountry)).EndInit();
            this.ImgBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.SplitContainer LeftSplitContainer;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroGrid GrdCountry;
        private MetroFramework.Controls.MetroLabel LbData;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TxtDeath;
        private System.Windows.Forms.Label TxtDecide;
        private System.Windows.Forms.Label TxtRate;
        private System.Windows.Forms.PictureBox ImgCountry;
        private System.Windows.Forms.FlowLayoutPanel ImgBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryEnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn continent;
        private System.Windows.Forms.DataGridViewTextBoxColumn basic;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgUrl;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}

