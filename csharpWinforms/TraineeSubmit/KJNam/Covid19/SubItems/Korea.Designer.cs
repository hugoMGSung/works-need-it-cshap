namespace Covid19.SubItems
{
    partial class Korea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvSearchItems = new MetroFramework.Controls.MetroGrid();
            this.gubun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gubunEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearchItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gubun,
            this.gubunEn,
            this.defCnt,
            this.incDec,
            this.deathCnt,
            this.stdDay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSearchItems.EnableHeadersVisualStyles = false;
            this.DgvSearchItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvSearchItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvSearchItems.Location = new System.Drawing.Point(23, 90);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearchItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSearchItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchItems.Size = new System.Drawing.Size(677, 352);
            this.DgvSearchItems.Style = MetroFramework.MetroColorStyle.Red;
            this.DgvSearchItems.TabIndex = 1;
            // 
            // gubun
            // 
            this.gubun.HeaderText = "지역명";
            this.gubun.Name = "gubun";
            // 
            // gubunEn
            // 
            this.gubunEn.HeaderText = "지역명 영문";
            this.gubunEn.Name = "gubunEn";
            // 
            // defCnt
            // 
            this.defCnt.HeaderText = "확진자 수";
            this.defCnt.Name = "defCnt";
            // 
            // incDec
            // 
            this.incDec.HeaderText = "증감수";
            this.incDec.Name = "incDec";
            // 
            // deathCnt
            // 
            this.deathCnt.HeaderText = "사망자 수";
            this.deathCnt.Name = "deathCnt";
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
            this.TxtSearchItem.Location = new System.Drawing.Point(474, 59);
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
            this.butSearch.Location = new System.Drawing.Point(620, 59);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(46, 25);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "검색";
            this.butSearch.UseSelectable = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(668, 448);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(59, 29);
            this.butHome.TabIndex = 5;
            this.butHome.Text = "처음으로";
            this.butHome.UseSelectable = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // Korea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.TxtSearchItem);
            this.Controls.Add(this.DgvSearchItems);
            this.Name = "Korea";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "국내_코로나_현황";
            this.Load += new System.EventHandler(this.Korea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DgvSearchItems;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroButton butSearch;
        private MetroFramework.Controls.MetroButton butHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gubun;
        private System.Windows.Forms.DataGridViewTextBoxColumn gubunEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn incDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDay;
    }
}