namespace Covid19.SubItems
{
    partial class OtherCountry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvSearchItems = new MetroFramework.Controls.MetroGrid();
            this.nationNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationNmEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natDefCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natDeathCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.butSearch = new MetroFramework.Controls.MetroButton();
            this.butHome = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToResizeRows = false;
            this.DgvSearchItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSearchItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvSearchItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearchItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nationNm,
            this.nationNmEn,
            this.natDefCnt,
            this.natDeathCnt,
            this.stdDay});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvSearchItems.EnableHeadersVisualStyles = false;
            this.DgvSearchItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvSearchItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvSearchItems.Location = new System.Drawing.Point(23, 90);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearchItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvSearchItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchItems.Size = new System.Drawing.Size(626, 350);
            this.DgvSearchItems.Style = MetroFramework.MetroColorStyle.Purple;
            this.DgvSearchItems.TabIndex = 1;
            // 
            // nationNm
            // 
            this.nationNm.HeaderText = "국가명";
            this.nationNm.Name = "nationNm";
            // 
            // nationNmEn
            // 
            this.nationNmEn.HeaderText = "국가명_영문";
            this.nationNmEn.Name = "nationNmEn";
            // 
            // natDefCnt
            // 
            this.natDefCnt.HeaderText = "확진자 수";
            this.natDefCnt.Name = "natDefCnt";
            // 
            // natDeathCnt
            // 
            this.natDeathCnt.HeaderText = "사망자 수";
            this.natDeathCnt.Name = "natDeathCnt";
            // 
            // stdDay
            // 
            this.stdDay.HeaderText = "기준일시";
            this.stdDay.Name = "stdDay";
            // 
            // TxtSearchItem
            // 
            // 
            // 
            // 
            this.TxtSearchItem.CustomButton.Image = null;
            this.TxtSearchItem.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.TxtSearchItem.CustomButton.Name = "";
            this.TxtSearchItem.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtSearchItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchItem.CustomButton.TabIndex = 1;
            this.TxtSearchItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchItem.CustomButton.UseSelectable = true;
            this.TxtSearchItem.CustomButton.Visible = false;
            this.TxtSearchItem.Lines = new string[0];
            this.TxtSearchItem.Location = new System.Drawing.Point(457, 59);
            this.TxtSearchItem.MaxLength = 32767;
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.PasswordChar = '\0';
            this.TxtSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchItem.SelectedText = "";
            this.TxtSearchItem.SelectionLength = 0;
            this.TxtSearchItem.SelectionStart = 0;
            this.TxtSearchItem.ShortcutsEnabled = true;
            this.TxtSearchItem.Size = new System.Drawing.Size(140, 25);
            this.TxtSearchItem.TabIndex = 3;
            this.TxtSearchItem.UseSelectable = true;
            this.TxtSearchItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(603, 59);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(46, 25);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "검색";
            this.butSearch.UseSelectable = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(655, 437);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(59, 29);
            this.butHome.TabIndex = 5;
            this.butHome.Text = "처음으로";
            this.butHome.UseSelectable = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // OtherCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.TxtSearchItem);
            this.Controls.Add(this.DgvSearchItems);
            this.Name = "OtherCountry";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "해외_코로나_현황";
            this.Load += new System.EventHandler(this.OtherCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DgvSearchItems;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroButton butSearch;
        private MetroFramework.Controls.MetroButton butHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationNmEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natDefCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn natDeathCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDay;
    }
}