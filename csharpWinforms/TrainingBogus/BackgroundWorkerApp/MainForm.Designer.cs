namespace BackgroundWorkerApp
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
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnStartAsync = new System.Windows.Forms.Button();
            this.BtnCancelAsync = new System.Windows.Forms.Button();
            this.BgwTest = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.Location = new System.Drawing.Point(28, 32);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(221, 21);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "0 %";
            // 
            // BtnStartAsync
            // 
            this.BtnStartAsync.Location = new System.Drawing.Point(31, 75);
            this.BtnStartAsync.Name = "BtnStartAsync";
            this.BtnStartAsync.Size = new System.Drawing.Size(106, 42);
            this.BtnStartAsync.TabIndex = 1;
            this.BtnStartAsync.Text = "Start";
            this.BtnStartAsync.UseVisualStyleBackColor = true;
            this.BtnStartAsync.Click += new System.EventHandler(this.BtnStartAsync_Click);
            // 
            // BtnCancelAsync
            // 
            this.BtnCancelAsync.Location = new System.Drawing.Point(143, 75);
            this.BtnCancelAsync.Name = "BtnCancelAsync";
            this.BtnCancelAsync.Size = new System.Drawing.Size(106, 42);
            this.BtnCancelAsync.TabIndex = 1;
            this.BtnCancelAsync.Text = "Cancel";
            this.BtnCancelAsync.UseVisualStyleBackColor = true;
            this.BtnCancelAsync.Click += new System.EventHandler(this.BtnCancelAsync_Click);
            // 
            // BgwTest
            // 
            this.BgwTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwTest_DoWork);
            this.BgwTest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwTest_ProgressChanged);
            this.BgwTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwTest_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 144);
            this.Controls.Add(this.BtnCancelAsync);
            this.Controls.Add(this.BtnStartAsync);
            this.Controls.Add(this.LblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BackgroundWorker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnStartAsync;
        private System.Windows.Forms.Button BtnCancelAsync;
        private System.ComponentModel.BackgroundWorker BgwTest;
    }
}

