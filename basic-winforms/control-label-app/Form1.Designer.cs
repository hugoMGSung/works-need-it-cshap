namespace control_label_app
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.llbGoogle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "타이틀";
            // 
            // lblContent
            // 
            this.lblContent.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContent.Location = new System.Drawing.Point(12, 60);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(582, 191);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Temporary";
            this.lblContent.Click += new System.EventHandler(this.lblContent_Click);
            // 
            // llbGoogle
            // 
            this.llbGoogle.AutoSize = true;
            this.llbGoogle.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.llbGoogle.Location = new System.Drawing.Point(528, 9);
            this.llbGoogle.Name = "llbGoogle";
            this.llbGoogle.Size = new System.Drawing.Size(66, 20);
            this.llbGoogle.TabIndex = 2;
            this.llbGoogle.TabStop = true;
            this.llbGoogle.Text = "Google";
            this.llbGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGoogle_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 260);
            this.Controls.Add(this.llbGoogle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.LinkLabel llbGoogle;
    }
}

