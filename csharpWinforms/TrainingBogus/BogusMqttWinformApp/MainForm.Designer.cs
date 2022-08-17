namespace BogusMqttWinformApp
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtMqttBrokerIp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BtnConnect = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.RtbLog = new System.Windows.Forms.RichTextBox();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.Location = new System.Drawing.Point(696, 3);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(29, 85);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(128, 24);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "MQTT Broker IP";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // TxtMqttBrokerIp
            // 
            this.TxtMqttBrokerIp.AutoCompleteCustomSource = null;
            this.TxtMqttBrokerIp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtMqttBrokerIp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtMqttBrokerIp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtMqttBrokerIp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtMqttBrokerIp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtMqttBrokerIp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TxtMqttBrokerIp.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMqttBrokerIp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtMqttBrokerIp.Image = null;
            this.TxtMqttBrokerIp.Lines = null;
            this.TxtMqttBrokerIp.Location = new System.Drawing.Point(173, 79);
            this.TxtMqttBrokerIp.MaxLength = 15;
            this.TxtMqttBrokerIp.Multiline = false;
            this.TxtMqttBrokerIp.Name = "TxtMqttBrokerIp";
            this.TxtMqttBrokerIp.ReadOnly = false;
            this.TxtMqttBrokerIp.Size = new System.Drawing.Size(480, 29);
            this.TxtMqttBrokerIp.Style = MetroSet_UI.Design.Style.Light;
            this.TxtMqttBrokerIp.StyleManager = null;
            this.TxtMqttBrokerIp.TabIndex = 2;
            this.TxtMqttBrokerIp.Text = "localhost";
            this.TxtMqttBrokerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMqttBrokerIp.ThemeAuthor = "Narwin";
            this.TxtMqttBrokerIp.ThemeName = "MetroLite";
            this.TxtMqttBrokerIp.UseSystemPasswordChar = false;
            this.TxtMqttBrokerIp.WatermarkText = "";
            // 
            // BtnConnect
            // 
            this.BtnConnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnConnect.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverTextColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(659, 79);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalTextColor = System.Drawing.Color.White;
            this.BtnConnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressTextColor = System.Drawing.Color.White;
            this.BtnConnect.Size = new System.Drawing.Size(126, 29);
            this.BtnConnect.Style = MetroSet_UI.Design.Style.Light;
            this.BtnConnect.StyleManager = null;
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.ThemeAuthor = "Narwin";
            this.BtnConnect.ThemeName = "MetroLite";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.RtbLog);
            this.metroSetPanel1.Location = new System.Drawing.Point(15, 114);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(770, 473);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 4;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // RtbLog
            // 
            this.RtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.RtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbLog.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RtbLog.Location = new System.Drawing.Point(0, 0);
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbLog.Size = new System.Drawing.Size(770, 473);
            this.RtbLog.TabIndex = 5;
            this.RtbLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtMqttBrokerIp);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12, 61, 12, 10);
            this.Text = "MQTT Fake Sendor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox TxtMqttBrokerIp;
        private MetroSet_UI.Controls.MetroSetButton BtnConnect;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private System.Windows.Forms.RichTextBox RtbLog;
    }
}

