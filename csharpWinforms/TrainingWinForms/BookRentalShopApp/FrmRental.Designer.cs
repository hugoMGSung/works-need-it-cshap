
namespace BookRentalShopApp
{
    partial class FrmRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRental));
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtBookName = new MetroFramework.Controls.MetroTextBox();
            this.TxtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CboRentalState = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtReturnDate = new MetroFramework.Controls.MetroTextBox();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.TxtReturnDate);
            this.GrbDetail.Controls.Add(this.CboRentalState);
            this.GrbDetail.Controls.Add(this.BtnSearchBook);
            this.GrbDetail.Controls.Add(this.BtnSearchMember);
            this.GrbDetail.Controls.Add(this.DtpRentalDate);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.TxtBookName);
            this.GrbDetail.Controls.Add(this.TxtMemberName);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel6);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.metroLabel5);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GrbDetail.Location = new System.Drawing.Point(440, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(337, 412);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.Image")));
            this.BtnSearchBook.Location = new System.Drawing.Point(286, 94);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(24, 23);
            this.BtnSearchBook.TabIndex = 6;
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.Image")));
            this.BtnSearchMember.Location = new System.Drawing.Point(286, 62);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(24, 23);
            this.BtnSearchMember.TabIndex = 4;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentalDate.Location = new System.Drawing.Point(98, 121);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(200, 29);
            this.DtpRentalDate.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(242, 365);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(161, 365);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 31);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtBookName
            // 
            // 
            // 
            // 
            this.TxtBookName.CustomButton.Image = null;
            this.TxtBookName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.TxtBookName.CustomButton.Name = "";
            this.TxtBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookName.CustomButton.TabIndex = 1;
            this.TxtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookName.CustomButton.UseSelectable = true;
            this.TxtBookName.CustomButton.Visible = false;
            this.TxtBookName.Lines = new string[0];
            this.TxtBookName.Location = new System.Drawing.Point(98, 94);
            this.TxtBookName.MaxLength = 32767;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.PasswordChar = '\0';
            this.TxtBookName.PromptText = "도서명";
            this.TxtBookName.ReadOnly = true;
            this.TxtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookName.SelectedText = "";
            this.TxtBookName.SelectionLength = 0;
            this.TxtBookName.SelectionStart = 0;
            this.TxtBookName.ShortcutsEnabled = true;
            this.TxtBookName.Size = new System.Drawing.Size(182, 23);
            this.TxtBookName.TabIndex = 5;
            this.TxtBookName.UseSelectable = true;
            this.TxtBookName.WaterMark = "도서명";
            this.TxtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtMemberName
            // 
            // 
            // 
            // 
            this.TxtMemberName.CustomButton.Image = null;
            this.TxtMemberName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.TxtMemberName.CustomButton.Name = "";
            this.TxtMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberName.CustomButton.TabIndex = 1;
            this.TxtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberName.CustomButton.UseSelectable = true;
            this.TxtMemberName.CustomButton.Visible = false;
            this.TxtMemberName.Lines = new string[0];
            this.TxtMemberName.Location = new System.Drawing.Point(98, 62);
            this.TxtMemberName.MaxLength = 32767;
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.PasswordChar = '\0';
            this.TxtMemberName.PromptText = "대여회원";
            this.TxtMemberName.ReadOnly = true;
            this.TxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberName.SelectedText = "";
            this.TxtMemberName.SelectionLength = 0;
            this.TxtMemberName.SelectionStart = 0;
            this.TxtMemberName.ShortcutsEnabled = true;
            this.TxtMemberName.Size = new System.Drawing.Size(182, 23);
            this.TxtMemberName.TabIndex = 3;
            this.TxtMemberName.UseSelectable = true;
            this.TxtMemberName.WaterMark = "대여회원";
            this.TxtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(98, 28);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(212, 23);
            this.TxtIdx.TabIndex = 2;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "도서명 :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "대여회원 :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "대여일 :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "순번 :";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(401, 412);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "대여상태 :";
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.ItemHeight = 23;
            this.CboRentalState.Location = new System.Drawing.Point(98, 185);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.Size = new System.Drawing.Size(121, 29);
            this.CboRentalState.TabIndex = 9;
            this.CboRentalState.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 163);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "반납일 :";
            // 
            // TxtReturnDate
            // 
            // 
            // 
            // 
            this.TxtReturnDate.CustomButton.Image = null;
            this.TxtReturnDate.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TxtReturnDate.CustomButton.Name = "";
            this.TxtReturnDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtReturnDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtReturnDate.CustomButton.TabIndex = 1;
            this.TxtReturnDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtReturnDate.CustomButton.UseSelectable = true;
            this.TxtReturnDate.CustomButton.Visible = false;
            this.TxtReturnDate.Lines = new string[0];
            this.TxtReturnDate.Location = new System.Drawing.Point(98, 159);
            this.TxtReturnDate.MaxLength = 32767;
            this.TxtReturnDate.Name = "TxtReturnDate";
            this.TxtReturnDate.PasswordChar = '\0';
            this.TxtReturnDate.ReadOnly = true;
            this.TxtReturnDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtReturnDate.SelectedText = "";
            this.TxtReturnDate.SelectionLength = 0;
            this.TxtReturnDate.SelectionStart = 0;
            this.TxtReturnDate.ShortcutsEnabled = true;
            this.TxtReturnDate.Size = new System.Drawing.Size(200, 23);
            this.TxtReturnDate.TabIndex = 13;
            this.TxtReturnDate.UseSelectable = true;
            this.TxtReturnDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtReturnDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmRental";
            this.Text = "대여관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtBookName;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private MetroFramework.Controls.MetroTextBox TxtMemberName;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.Button BtnSearchBook;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CboRentalState;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TxtReturnDate;
    }
}