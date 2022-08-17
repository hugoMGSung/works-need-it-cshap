namespace TensorflowTestApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSelectImage = new System.Windows.Forms.Button();
            this.TxtSelectImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RtbLogs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PbxSelectImage = new System.Windows.Forms.PictureBox();
            this.BtnStartProcess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PbxSelectImage);
            this.groupBox1.Controls.Add(this.RtbLogs);
            this.groupBox1.Controls.Add(this.BtnStartProcess);
            this.groupBox1.Controls.Add(this.BtnSelectImage);
            this.groupBox1.Controls.Add(this.TxtSelectImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Learning";
            // 
            // BtnSelectImage
            // 
            this.BtnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectImage.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSelectImage.Location = new System.Drawing.Point(829, 22);
            this.BtnSelectImage.Name = "BtnSelectImage";
            this.BtnSelectImage.Size = new System.Drawing.Size(114, 36);
            this.BtnSelectImage.TabIndex = 2;
            this.BtnSelectImage.Text = "Image File";
            this.BtnSelectImage.UseVisualStyleBackColor = true;
            this.BtnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // TxtSelectImage
            // 
            this.TxtSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSelectImage.Enabled = false;
            this.TxtSelectImage.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtSelectImage.Location = new System.Drawing.Point(139, 28);
            this.TxtSelectImage.Name = "TxtSelectImage";
            this.TxtSelectImage.Size = new System.Drawing.Size(684, 25);
            this.TxtSelectImage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "이미지 선택";
            // 
            // RtbLogs
            // 
            this.RtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbLogs.Enabled = false;
            this.RtbLogs.Location = new System.Drawing.Point(139, 463);
            this.RtbLogs.Name = "RtbLogs";
            this.RtbLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbLogs.Size = new System.Drawing.Size(804, 127);
            this.RtbLogs.TabIndex = 4;
            this.RtbLogs.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(24, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "로그";
            // 
            // PbxSelectImage
            // 
            this.PbxSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxSelectImage.BackColor = System.Drawing.SystemColors.Control;
            this.PbxSelectImage.Location = new System.Drawing.Point(139, 64);
            this.PbxSelectImage.Name = "PbxSelectImage";
            this.PbxSelectImage.Size = new System.Drawing.Size(684, 393);
            this.PbxSelectImage.TabIndex = 5;
            this.PbxSelectImage.TabStop = false;
            // 
            // BtnStartProcess
            // 
            this.BtnStartProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStartProcess.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStartProcess.Location = new System.Drawing.Point(829, 64);
            this.BtnStartProcess.Name = "BtnStartProcess";
            this.BtnStartProcess.Size = new System.Drawing.Size(114, 36);
            this.BtnStartProcess.TabIndex = 2;
            this.BtnStartProcess.Text = "Inference";
            this.BtnStartProcess.UseVisualStyleBackColor = true;
            this.BtnStartProcess.Click += new System.EventHandler(this.BtnStartProcess_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 620);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "TensorflowSharp Test App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSelectImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectImage;
        private System.Windows.Forms.TextBox TxtSelectImage;
        private System.Windows.Forms.RichTextBox RtbLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbxSelectImage;
        private System.Windows.Forms.Button BtnStartProcess;
    }
}

