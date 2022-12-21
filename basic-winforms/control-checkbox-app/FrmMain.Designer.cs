namespace control_checkbox_app
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
            this.ChkMonitoringBathHumid = new System.Windows.Forms.CheckBox();
            this.ChkMonitoringBed = new System.Windows.Forms.CheckBox();
            this.ChkSubBedTemp = new System.Windows.Forms.CheckBox();
            this.ChkSubBedHumid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChkMonitoringBathHumid
            // 
            this.ChkMonitoringBathHumid.AutoSize = true;
            this.ChkMonitoringBathHumid.Location = new System.Drawing.Point(46, 41);
            this.ChkMonitoringBathHumid.Name = "ChkMonitoringBathHumid";
            this.ChkMonitoringBathHumid.Size = new System.Drawing.Size(159, 19);
            this.ChkMonitoringBathHumid.TabIndex = 0;
            this.ChkMonitoringBathHumid.Text = "욕실 습도 모니터링";
            this.ChkMonitoringBathHumid.UseVisualStyleBackColor = true;
            // 
            // ChkMonitoringBed
            // 
            this.ChkMonitoringBed.AutoSize = true;
            this.ChkMonitoringBed.Checked = true;
            this.ChkMonitoringBed.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ChkMonitoringBed.Location = new System.Drawing.Point(46, 66);
            this.ChkMonitoringBed.Name = "ChkMonitoringBed";
            this.ChkMonitoringBed.Size = new System.Drawing.Size(124, 19);
            this.ChkMonitoringBed.TabIndex = 0;
            this.ChkMonitoringBed.Text = "침실 모니터링";
            this.ChkMonitoringBed.ThreeState = true;
            this.ChkMonitoringBed.UseVisualStyleBackColor = true;
            this.ChkMonitoringBed.CheckedChanged += new System.EventHandler(this.ChkMonitoringBed_CheckedChanged);
            // 
            // ChkSubBedTemp
            // 
            this.ChkSubBedTemp.AutoSize = true;
            this.ChkSubBedTemp.Checked = true;
            this.ChkSubBedTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSubBedTemp.Location = new System.Drawing.Point(68, 91);
            this.ChkSubBedTemp.Name = "ChkSubBedTemp";
            this.ChkSubBedTemp.Size = new System.Drawing.Size(94, 19);
            this.ChkSubBedTemp.TabIndex = 0;
            this.ChkSubBedTemp.Text = "침실 온도";
            this.ChkSubBedTemp.UseVisualStyleBackColor = true;
            this.ChkSubBedTemp.CheckedChanged += new System.EventHandler(this.ChkSubBedTemp_CheckedChanged);
            // 
            // ChkSubBedHumid
            // 
            this.ChkSubBedHumid.AutoSize = true;
            this.ChkSubBedHumid.Location = new System.Drawing.Point(68, 116);
            this.ChkSubBedHumid.Name = "ChkSubBedHumid";
            this.ChkSubBedHumid.Size = new System.Drawing.Size(94, 19);
            this.ChkSubBedHumid.TabIndex = 0;
            this.ChkSubBedHumid.Text = "침실 습도";
            this.ChkSubBedHumid.UseVisualStyleBackColor = true;
            this.ChkSubBedHumid.CheckedChanged += new System.EventHandler(this.ChkSubBedHumid_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 194);
            this.Controls.Add(this.ChkSubBedHumid);
            this.Controls.Add(this.ChkSubBedTemp);
            this.Controls.Add(this.ChkMonitoringBed);
            this.Controls.Add(this.ChkMonitoringBathHumid);
            this.Name = "FrmMain";
            this.Text = "메인화면";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkMonitoringBathHumid;
        private System.Windows.Forms.CheckBox ChkMonitoringBed;
        private System.Windows.Forms.CheckBox ChkSubBedTemp;
        private System.Windows.Forms.CheckBox ChkSubBedHumid;
    }
}

