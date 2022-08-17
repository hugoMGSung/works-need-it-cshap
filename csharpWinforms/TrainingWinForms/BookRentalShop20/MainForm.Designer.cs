namespace BookRentalShop20
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDivMng = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.책관리BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemDivMng,
            this.사용자관리UToolStripMenuItem,
            this.회원관리MToolStripMenuItem,
            this.책관리BToolStripMenuItem});
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(146, 34);
            this.MnuMain.Text = "메인관리(&M)";
            // 
            // MnuItemDivMng
            // 
            this.MnuItemDivMng.Name = "MnuItemDivMng";
            this.MnuItemDivMng.Size = new System.Drawing.Size(315, 40);
            this.MnuItemDivMng.Text = "구분코드관리(&D)";
            this.MnuItemDivMng.Click += new System.EventHandler(this.MnuItemDivMng_Click);
            // 
            // 사용자관리UToolStripMenuItem
            // 
            this.사용자관리UToolStripMenuItem.Name = "사용자관리UToolStripMenuItem";
            this.사용자관리UToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.사용자관리UToolStripMenuItem.Text = "사용자관리(&U)";
            this.사용자관리UToolStripMenuItem.Click += new System.EventHandler(this.사용자관리UToolStripMenuItem_Click);
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.회원관리MToolStripMenuItem.Text = "회원관리(&M)";
            this.회원관리MToolStripMenuItem.Click += new System.EventHandler(this.회원관리MToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "접속아이디 : ";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Location = new System.Drawing.Point(665, 26);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(0, 21);
            this.LblUserID.TabIndex = 3;
            // 
            // 책관리BToolStripMenuItem
            // 
            this.책관리BToolStripMenuItem.Name = "책관리BToolStripMenuItem";
            this.책관리BToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.책관리BToolStripMenuItem.Text = "책관리(&B)";
            this.책관리BToolStripMenuItem.Click += new System.EventHandler(this.책관리BToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Book Rentalshop v1.0";
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
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDivMng;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.ToolStripMenuItem 책관리BToolStripMenuItem;
    }
}

