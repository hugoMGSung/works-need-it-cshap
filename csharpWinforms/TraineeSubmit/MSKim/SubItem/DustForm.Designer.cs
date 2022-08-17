namespace WinFormTest.SubItem
{
    partial class DustForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DustForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TextSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.ItemSearch = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemExit = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TextSearchItem);
            this.splitContainer1.Panel1.Controls.Add(this.ItemSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(542, 560);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 5;
            // 
            // TextSearchItem
            // 
            // 
            // 
            // 
            this.TextSearchItem.CustomButton.Image = null;
            this.TextSearchItem.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.TextSearchItem.CustomButton.Name = "";
            this.TextSearchItem.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TextSearchItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextSearchItem.CustomButton.TabIndex = 1;
            this.TextSearchItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextSearchItem.CustomButton.UseSelectable = true;
            this.TextSearchItem.CustomButton.Visible = false;
            this.TextSearchItem.Lines = new string[] {
        "빈칸 - 전체 결과 검색"};
            this.TextSearchItem.Location = new System.Drawing.Point(293, 28);
            this.TextSearchItem.MaxLength = 32767;
            this.TextSearchItem.Name = "TextSearchItem";
            this.TextSearchItem.PasswordChar = '\0';
            this.TextSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextSearchItem.SelectedText = "";
            this.TextSearchItem.SelectionLength = 0;
            this.TextSearchItem.SelectionStart = 0;
            this.TextSearchItem.ShortcutsEnabled = true;
            this.TextSearchItem.Size = new System.Drawing.Size(150, 25);
            this.TextSearchItem.TabIndex = 0;
            this.TextSearchItem.Text = "빈칸 - 전체 결과 검색";
            this.TextSearchItem.UseSelectable = true;
            this.TextSearchItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextSearchItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextSearchItem.Click += new System.EventHandler(this.TextSearchItem_Click);
            this.TextSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchItem_KeyPress);
            // 
            // ItemSearch
            // 
            this.ItemSearch.ActiveControl = null;
            this.ItemSearch.Location = new System.Drawing.Point(449, 0);
            this.ItemSearch.Name = "ItemSearch";
            this.ItemSearch.Size = new System.Drawing.Size(92, 55);
            this.ItemSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ItemSearch.TabIndex = 1;
            this.ItemSearch.Text = "검색";
            this.ItemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemSearch.UseSelectable = true;
            this.ItemSearch.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.site,
            this.controlnumber,
            this.o3,
            this.pm25,
            this.pm10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 3);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(125)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 23;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(542, 499);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroGrid1.TabIndex = 3;
            // 
            // site
            // 
            this.site.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.site.HeaderText = "지역이름";
            this.site.Name = "site";
            // 
            // controlnumber
            // 
            this.controlnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.controlnumber.HeaderText = "측정시간";
            this.controlnumber.Name = "controlnumber";
            // 
            // o3
            // 
            this.o3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.o3.HeaderText = "오존";
            this.o3.Name = "o3";
            // 
            // pm25
            // 
            this.pm25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pm25.HeaderText = "초미세먼지";
            this.pm25.Name = "pm25";
            // 
            // pm10
            // 
            this.pm10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pm10.HeaderText = "미세먼지";
            this.pm10.Name = "pm10";
            // 
            // ItemExit
            // 
            this.ItemExit.ActiveControl = null;
            this.ItemExit.Location = new System.Drawing.Point(541, 33);
            this.ItemExit.Name = "ItemExit";
            this.ItemExit.Size = new System.Drawing.Size(18, 21);
            this.ItemExit.Style = MetroFramework.MetroColorStyle.Pink;
            this.ItemExit.TabIndex = 4;
            this.ItemExit.TileImage = global::WinFormTest.Properties.Resources.back2;
            this.ItemExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemExit.UseSelectable = true;
            this.ItemExit.UseTileImage = true;
            this.ItemExit.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // DustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 640);
            this.Controls.Add(this.ItemExit);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DustForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Load += new System.EventHandler(this.DustForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile ItemSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn o3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm25;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm10;
        private MetroFramework.Controls.MetroTextBox TextSearchItem;
        private MetroFramework.Controls.MetroTile ItemExit;
    }
}