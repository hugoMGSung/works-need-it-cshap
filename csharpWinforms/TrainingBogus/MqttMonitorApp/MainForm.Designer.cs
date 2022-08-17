namespace MqttMonitorApp
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.TxtConnString = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.BtnConnect = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnDisconnect = new MetroSet_UI.Controls.MetroSetButton();
            this.RtbLog = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.TxtPubishTopic = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1175, 6);
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
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(12, 171);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1256, 537);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.RtbLog);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(1248, 491);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Database Monitoring";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(1248, 533);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage2.StyleManager = null;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "Realtime Monitoring";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroLite";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.BtnDisconnect);
            this.metroSetPanel1.Controls.Add(this.BtnConnect);
            this.metroSetPanel1.Controls.Add(this.metroSetLabel2);
            this.metroSetPanel1.Controls.Add(this.TxtPubishTopic);
            this.metroSetPanel1.Controls.Add(this.metroSetLabel1);
            this.metroSetPanel1.Controls.Add(this.TxtConnString);
            this.metroSetPanel1.Location = new System.Drawing.Point(12, 85);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(1252, 80);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // TxtConnString
            // 
            this.TxtConnString.AutoCompleteCustomSource = null;
            this.TxtConnString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtConnString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtConnString.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtConnString.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtConnString.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtConnString.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TxtConnString.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConnString.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtConnString.Image = null;
            this.TxtConnString.Lines = null;
            this.TxtConnString.Location = new System.Drawing.Point(117, 43);
            this.TxtConnString.MaxLength = 32767;
            this.TxtConnString.Multiline = false;
            this.TxtConnString.Name = "TxtConnString";
            this.TxtConnString.ReadOnly = false;
            this.TxtConnString.Size = new System.Drawing.Size(838, 29);
            this.TxtConnString.Style = MetroSet_UI.Design.Style.Light;
            this.TxtConnString.StyleManager = null;
            this.TxtConnString.TabIndex = 1;
            this.TxtConnString.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtConnString.ThemeAuthor = "Narwin";
            this.TxtConnString.ThemeName = "MetroLite";
            this.TxtConnString.UseSystemPasswordChar = false;
            this.TxtConnString.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 47);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(102, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Database Info";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // BtnConnect
            // 
            this.BtnConnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnConnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnConnect.HoverTextColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(1108, 7);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnConnect.NormalTextColor = System.Drawing.Color.White;
            this.BtnConnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnConnect.PressTextColor = System.Drawing.Color.White;
            this.BtnConnect.Size = new System.Drawing.Size(141, 30);
            this.BtnConnect.Style = MetroSet_UI.Design.Style.Light;
            this.BtnConnect.StyleManager = null;
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "CONNECT";
            this.BtnConnect.ThemeAuthor = "Narwin";
            this.BtnConnect.ThemeName = "MetroLite";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDisconnect.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDisconnect.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDisconnect.HoverTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.Location = new System.Drawing.Point(1108, 43);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDisconnect.NormalTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDisconnect.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDisconnect.PressTextColor = System.Drawing.Color.White;
            this.BtnDisconnect.Size = new System.Drawing.Size(141, 30);
            this.BtnDisconnect.Style = MetroSet_UI.Design.Style.Light;
            this.BtnDisconnect.StyleManager = null;
            this.BtnDisconnect.TabIndex = 3;
            this.BtnDisconnect.Text = "DISCONNECT";
            this.BtnDisconnect.ThemeAuthor = "Narwin";
            this.BtnDisconnect.ThemeName = "MetroLite";
            // 
            // RtbLog
            // 
            this.RtbLog.AutoWordSelection = false;
            this.RtbLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RtbLog.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RtbLog.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RtbLog.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.RtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RtbLog.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RtbLog.Lines = null;
            this.RtbLog.Location = new System.Drawing.Point(3, 3);
            this.RtbLog.MaxLength = 32767;
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.ReadOnly = false;
            this.RtbLog.Size = new System.Drawing.Size(1242, 527);
            this.RtbLog.Style = MetroSet_UI.Design.Style.Light;
            this.RtbLog.StyleManager = null;
            this.RtbLog.TabIndex = 0;
            this.RtbLog.ThemeAuthor = "Narwin";
            this.RtbLog.ThemeName = "MetroLite";
            this.RtbLog.WordWrap = true;
            // 
            // TxtPubishTopic
            // 
            this.TxtPubishTopic.AutoCompleteCustomSource = null;
            this.TxtPubishTopic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPubishTopic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPubishTopic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtPubishTopic.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtPubishTopic.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TxtPubishTopic.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TxtPubishTopic.Font = new System.Drawing.Font("나눔고딕", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPubishTopic.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TxtPubishTopic.Image = null;
            this.TxtPubishTopic.Lines = null;
            this.TxtPubishTopic.Location = new System.Drawing.Point(117, 7);
            this.TxtPubishTopic.MaxLength = 32767;
            this.TxtPubishTopic.Multiline = false;
            this.TxtPubishTopic.Name = "TxtPubishTopic";
            this.TxtPubishTopic.ReadOnly = false;
            this.TxtPubishTopic.Size = new System.Drawing.Size(838, 29);
            this.TxtPubishTopic.Style = MetroSet_UI.Design.Style.Light;
            this.TxtPubishTopic.StyleManager = null;
            this.TxtPubishTopic.TabIndex = 0;
            this.TxtPubishTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPubishTopic.ThemeAuthor = "Narwin";
            this.TxtPubishTopic.ThemeName = "MetroLite";
            this.TxtPubishTopic.UseSystemPasswordChar = false;
            this.TxtPubishTopic.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(6, 11);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(102, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Publish Info";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT Database App";
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetTextBox TxtConnString;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton BtnDisconnect;
        private MetroSet_UI.Controls.MetroSetButton BtnConnect;
        private MetroSet_UI.Controls.MetroSetRichTextBox RtbLog;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox TxtPubishTopic;
    }
}

