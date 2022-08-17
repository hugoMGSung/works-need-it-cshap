namespace BookRentalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCodeMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemMemerMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemRentalMng = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblDisplayUserID = new MetroFramework.Controls.MetroLabel();
            this.MnuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuManagement});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuManagement
            // 
            this.MnuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCodeMng,
            this.MnuItemMemerMng,
            this.MnuItemRentalMng,
            this.MnuItemLogin});
            this.MnuManagement.Name = "MnuManagement";
            this.MnuManagement.Size = new System.Drawing.Size(79, 25);
            this.MnuManagement.Text = "관리(&M)";
            // 
            // MnuItemCodeMng
            // 
            this.MnuItemCodeMng.Name = "MnuItemCodeMng";
            this.MnuItemCodeMng.Size = new System.Drawing.Size(198, 26);
            this.MnuItemCodeMng.Text = "코드관리(&C)";
            this.MnuItemCodeMng.Click += new System.EventHandler(this.MnuItemCodeMng_Click);
            // 
            // MnuItemMemerMng
            // 
            this.MnuItemMemerMng.Name = "MnuItemMemerMng";
            this.MnuItemMemerMng.Size = new System.Drawing.Size(198, 26);
            this.MnuItemMemerMng.Text = "회원관리(&M)";
            this.MnuItemMemerMng.Click += new System.EventHandler(this.MnuItemMemerMng_Click);
            // 
            // MnuItemRentalMng
            // 
            this.MnuItemRentalMng.Name = "MnuItemRentalMng";
            this.MnuItemRentalMng.Size = new System.Drawing.Size(198, 26);
            this.MnuItemRentalMng.Text = "대여관리(&R)";
            this.MnuItemRentalMng.Click += new System.EventHandler(this.MnuItemRentalMng_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(513, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "로그인 : ";
            this.metroLabel1.Click += new System.EventHandler(this.a);
            // 
            // LblDisplayUserID
            // 
            this.LblDisplayUserID.Location = new System.Drawing.Point(581, 32);
            this.LblDisplayUserID.Name = "LblDisplayUserID";
            this.LblDisplayUserID.Size = new System.Drawing.Size(155, 19);
            this.LblDisplayUserID.TabIndex = 3;
            this.LblDisplayUserID.Click += new System.EventHandler(this.a);
            // 
            // MnuItemLogin
            // 
            this.MnuItemLogin.Name = "MnuItemLogin";
            this.MnuItemLogin.Size = new System.Drawing.Size(198, 26);
            this.MnuItemLogin.Text = "로그인관리(&L)";
            this.MnuItemLogin.Click += new System.EventHandler(this.MnuItemLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 570);
            this.Controls.Add(this.LblDisplayUserID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Book Rental Shop v0.5";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuManagement;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCodeMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemMemerMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemRentalMng;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblDisplayUserID;
        private System.Windows.Forms.ToolStripMenuItem MnuItemLogin;
    }
}

