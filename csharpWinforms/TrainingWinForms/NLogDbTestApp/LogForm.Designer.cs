
namespace NLogDbTestApp
{
    partial class LogForm
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
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnWarn = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.BtnFatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(31, 28);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(120, 49);
            this.BtnInfo.TabIndex = 0;
            this.BtnInfo.Text = "Info Log";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnWarn
            // 
            this.BtnWarn.Location = new System.Drawing.Point(157, 28);
            this.BtnWarn.Name = "BtnWarn";
            this.BtnWarn.Size = new System.Drawing.Size(120, 49);
            this.BtnWarn.TabIndex = 0;
            this.BtnWarn.Text = "Warn Log";
            this.BtnWarn.UseVisualStyleBackColor = true;
            this.BtnWarn.Click += new System.EventHandler(this.BtnWarn_Click);
            // 
            // BtnError
            // 
            this.BtnError.Location = new System.Drawing.Point(283, 28);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(120, 49);
            this.BtnError.TabIndex = 1;
            this.BtnError.Text = "Error Log";
            this.BtnError.UseVisualStyleBackColor = true;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // BtnFatal
            // 
            this.BtnFatal.Location = new System.Drawing.Point(409, 28);
            this.BtnFatal.Name = "BtnFatal";
            this.BtnFatal.Size = new System.Drawing.Size(120, 49);
            this.BtnFatal.TabIndex = 2;
            this.BtnFatal.Text = "Fatal Log";
            this.BtnFatal.UseVisualStyleBackColor = true;
            this.BtnFatal.Click += new System.EventHandler(this.BtnFatal_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFatal);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.BtnWarn);
            this.Controls.Add(this.BtnInfo);
            this.Name = "LogForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnWarn;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.Button BtnFatal;
    }
}

