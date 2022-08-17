
namespace RecognitionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PbxCamera = new System.Windows.Forms.PictureBox();
            this.BgwVideo = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReconize = new System.Windows.Forms.Button();
            this.PbxCaptured = new System.Windows.Forms.PictureBox();
            this.TxtReqResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaptured)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxCamera
            // 
            this.PbxCamera.BackColor = System.Drawing.Color.Blue;
            this.PbxCamera.Location = new System.Drawing.Point(12, 12);
            this.PbxCamera.Name = "PbxCamera";
            this.PbxCamera.Size = new System.Drawing.Size(800, 600);
            this.PbxCamera.TabIndex = 0;
            this.PbxCamera.TabStop = false;
            // 
            // BgwVideo
            // 
            this.BgwVideo.WorkerReportsProgress = true;
            this.BgwVideo.WorkerSupportsCancellation = true;
            this.BgwVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwVideo_DoWork);
            this.BgwVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwVideo_ProgressChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtReqResult);
            this.groupBox1.Controls.Add(this.PbxCaptured);
            this.groupBox1.Controls.Add(this.BtnReconize);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(818, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 598);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결과처리";
            // 
            // BtnReconize
            // 
            this.BtnReconize.Location = new System.Drawing.Point(208, 539);
            this.BtnReconize.Name = "BtnReconize";
            this.BtnReconize.Size = new System.Drawing.Size(121, 43);
            this.BtnReconize.TabIndex = 0;
            this.BtnReconize.Text = "확인";
            this.BtnReconize.UseVisualStyleBackColor = true;
            this.BtnReconize.Click += new System.EventHandler(this.BtnReconize_Click);
            // 
            // PbxCaptured
            // 
            this.PbxCaptured.Location = new System.Drawing.Point(19, 35);
            this.PbxCaptured.Name = "PbxCaptured";
            this.PbxCaptured.Size = new System.Drawing.Size(310, 205);
            this.PbxCaptured.TabIndex = 1;
            this.PbxCaptured.TabStop = false;
            // 
            // TxtReqResult
            // 
            this.TxtReqResult.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtReqResult.Location = new System.Drawing.Point(19, 255);
            this.TxtReqResult.Name = "TxtReqResult";
            this.TxtReqResult.Size = new System.Drawing.Size(310, 34);
            this.TxtReqResult.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PbxCamera);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "OpenCV App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCamera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCaptured)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCamera;
        private System.ComponentModel.BackgroundWorker BgwVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReconize;
        private System.Windows.Forms.PictureBox PbxCaptured;
        private System.Windows.Forms.TextBox TxtReqResult;
    }
}

