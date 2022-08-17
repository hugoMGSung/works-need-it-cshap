namespace MyMovieApp.SubItems
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.MtlBack = new MetroFramework.Controls.MetroTile();
            this.movieCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNmEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtStatNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItems);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 694);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1162, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchItem
            // 
            // 
            // 
            // 
            this.TxtSearchItem.CustomButton.Image = null;
            this.TxtSearchItem.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtSearchItem.CustomButton.Name = "";
            this.TxtSearchItem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearchItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchItem.CustomButton.TabIndex = 1;
            this.TxtSearchItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchItem.CustomButton.UseSelectable = true;
            this.TxtSearchItem.CustomButton.Visible = false;
            this.TxtSearchItem.Lines = new string[0];
            this.TxtSearchItem.Location = new System.Drawing.Point(963, 3);
            this.TxtSearchItem.MaxLength = 32767;
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.PasswordChar = '\0';
            this.TxtSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchItem.SelectedText = "";
            this.TxtSearchItem.SelectionLength = 0;
            this.TxtSearchItem.SelectionStart = 0;
            this.TxtSearchItem.ShortcutsEnabled = true;
            this.TxtSearchItem.Size = new System.Drawing.Size(193, 23);
            this.TxtSearchItem.TabIndex = 0;
            this.TxtSearchItem.UseSelectable = true;
            this.TxtSearchItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchItem.Click += new System.EventHandler(this.TxtSearchItem_Click);
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieCd,
            this.movieNm,
            this.movieNmEn,
            this.prdtYear,
            this.openDt,
            this.typeNm,
            this.prdtStatNm,
            this.nationAlt,
            this.genreAlt,
            this.directors,
            this.companys});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.ReadOnly = true;
            this.DgvSearchItems.RowHeadersWidth = 40;
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(1240, 634);
            this.DgvSearchItems.TabIndex = 0;
            // 
            // MtlBack
            // 
            this.MtlBack.ActiveControl = null;
            this.MtlBack.Location = new System.Drawing.Point(132, 18);
            this.MtlBack.Name = "MtlBack";
            this.MtlBack.Size = new System.Drawing.Size(38, 36);
            this.MtlBack.Style = MetroFramework.MetroColorStyle.Silver;
            this.MtlBack.TabIndex = 1;
            this.MtlBack.TileImage = ((System.Drawing.Image)(resources.GetObject("MtlBack.TileImage")));
            this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlBack.UseSelectable = true;
            this.MtlBack.UseTileImage = true;
            this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
            // 
            // movieCd
            // 
            this.movieCd.HeaderText = "영화코드";
            this.movieCd.Name = "movieCd";
            this.movieCd.ReadOnly = true;
            // 
            // movieNm
            // 
            this.movieNm.HeaderText = "영화명(국문)";
            this.movieNm.Name = "movieNm";
            this.movieNm.ReadOnly = true;
            // 
            // movieNmEn
            // 
            this.movieNmEn.HeaderText = "영화명(영문)";
            this.movieNmEn.Name = "movieNmEn";
            this.movieNmEn.ReadOnly = true;
            // 
            // prdtYear
            // 
            this.prdtYear.HeaderText = "제작연도";
            this.prdtYear.Name = "prdtYear";
            this.prdtYear.ReadOnly = true;
            // 
            // openDt
            // 
            this.openDt.HeaderText = "개봉연도";
            this.openDt.Name = "openDt";
            this.openDt.ReadOnly = true;
            // 
            // typeNm
            // 
            this.typeNm.HeaderText = "영화유형";
            this.typeNm.Name = "typeNm";
            this.typeNm.ReadOnly = true;
            // 
            // prdtStatNm
            // 
            this.prdtStatNm.HeaderText = "제작상태";
            this.prdtStatNm.Name = "prdtStatNm";
            this.prdtStatNm.ReadOnly = true;
            // 
            // nationAlt
            // 
            this.nationAlt.HeaderText = "제작국가(전체)";
            this.nationAlt.Name = "nationAlt";
            this.nationAlt.ReadOnly = true;
            // 
            // genreAlt
            // 
            this.genreAlt.HeaderText = "영화장르(전체)";
            this.genreAlt.Name = "genreAlt";
            this.genreAlt.ReadOnly = true;
            // 
            // directors
            // 
            this.directors.HeaderText = "영화감독";
            this.directors.Name = "directors";
            this.directors.ReadOnly = true;
            // 
            // companys
            // 
            this.companys.HeaderText = "영화제작사";
            this.companys.Name = "companys";
            this.companys.ReadOnly = true;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 774);
            this.Controls.Add(this.MtlBack);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TitleForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "영화검색";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroTile MtlBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNmEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtStatNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn directors;
        private System.Windows.Forms.DataGridViewTextBoxColumn companys;
    }
}