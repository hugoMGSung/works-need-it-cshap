
namespace LabelTestApp
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
            this.BtnPushText = new System.Windows.Forms.Button();
            this.LblAutoSize = new System.Windows.Forms.Label();
            this.LblManualSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPushText
            // 
            this.BtnPushText.Location = new System.Drawing.Point(12, 12);
            this.BtnPushText.Name = "BtnPushText";
            this.BtnPushText.Size = new System.Drawing.Size(110, 30);
            this.BtnPushText.TabIndex = 0;
            this.BtnPushText.Text = "텍스트 입력";
            this.BtnPushText.UseVisualStyleBackColor = true;
            this.BtnPushText.Click += new System.EventHandler(this.BtnPushText_Click);
            // 
            // LblAutoSize
            // 
            this.LblAutoSize.AutoSize = true;
            this.LblAutoSize.Location = new System.Drawing.Point(12, 58);
            this.LblAutoSize.Name = "LblAutoSize";
            this.LblAutoSize.Size = new System.Drawing.Size(72, 12);
            this.LblAutoSize.TabIndex = 1;
            this.LblAutoSize.Text = "LblAutoSize";
            // 
            // LblManualSize
            // 
            this.LblManualSize.Location = new System.Drawing.Point(12, 86);
            this.LblManualSize.Name = "LblManualSize";
            this.LblManualSize.Size = new System.Drawing.Size(460, 121);
            this.LblManualSize.TabIndex = 2;
            this.LblManualSize.Text = "LblManualSize";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 216);
            this.Controls.Add(this.LblManualSize);
            this.Controls.Add(this.LblAutoSize);
            this.Controls.Add(this.BtnPushText);
            this.Name = "FrmMain";
            this.Text = "Label Control App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPushText;
        private System.Windows.Forms.Label LblAutoSize;
        private System.Windows.Forms.Label LblManualSize;
    }
}

