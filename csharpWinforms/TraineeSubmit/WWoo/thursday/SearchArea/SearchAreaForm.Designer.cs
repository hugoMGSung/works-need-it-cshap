namespace thursday.SearchArea
{
    partial class SearchAreaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAreaForm));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.새로만들기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.열기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.저장ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.인쇄ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.복사ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.붙여넣기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(1091, 728);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(161, 141);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.TileImage = global::thursday.Properties.Resources.icon__5_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "시도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "시,군,구";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "읍,면,동";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(289, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(507, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 20);
            this.comboBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(704, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "지역코드";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1073, 811);
            this.webBrowser1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripButton,
            this.열기ToolStripButton,
            this.저장ToolStripButton,
            this.인쇄ToolStripButton,
            this.toolStripSeparator,
            this.잘라내기ToolStripButton,
            this.복사ToolStripButton,
            this.붙여넣기ToolStripButton,
            this.toolStripSeparator1,
            this.도움말ToolStripButton,
            this.btnBack,
            this.btnForward,
            this.btnGo,
            this.btnStop,
            this.txtUrl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 새로만들기ToolStripButton
            // 
            this.새로만들기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.새로만들기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("새로만들기ToolStripButton.Image")));
            this.새로만들기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.새로만들기ToolStripButton.Name = "새로만들기ToolStripButton";
            this.새로만들기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.새로만들기ToolStripButton.Text = "새로 만들기";
            // 
            // 열기ToolStripButton
            // 
            this.열기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.열기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("열기ToolStripButton.Image")));
            this.열기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.열기ToolStripButton.Name = "열기ToolStripButton";
            this.열기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.열기ToolStripButton.Text = "열기";
            // 
            // 저장ToolStripButton
            // 
            this.저장ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.저장ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("저장ToolStripButton.Image")));
            this.저장ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.저장ToolStripButton.Name = "저장ToolStripButton";
            this.저장ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.저장ToolStripButton.Text = "저장";
            // 
            // 인쇄ToolStripButton
            // 
            this.인쇄ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.인쇄ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("인쇄ToolStripButton.Image")));
            this.인쇄ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.인쇄ToolStripButton.Name = "인쇄ToolStripButton";
            this.인쇄ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.인쇄ToolStripButton.Text = "인쇄";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 잘라내기ToolStripButton
            // 
            this.잘라내기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.잘라내기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("잘라내기ToolStripButton.Image")));
            this.잘라내기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.잘라내기ToolStripButton.Name = "잘라내기ToolStripButton";
            this.잘라내기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.잘라내기ToolStripButton.Text = "잘라내기";
            // 
            // 복사ToolStripButton
            // 
            this.복사ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.복사ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("복사ToolStripButton.Image")));
            this.복사ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.복사ToolStripButton.Name = "복사ToolStripButton";
            this.복사ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.복사ToolStripButton.Text = "복사";
            // 
            // 붙여넣기ToolStripButton
            // 
            this.붙여넣기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.붙여넣기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("붙여넣기ToolStripButton.Image")));
            this.붙여넣기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.붙여넣기ToolStripButton.Name = "붙여넣기ToolStripButton";
            this.붙여넣기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.붙여넣기ToolStripButton.Text = "붙여넣기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 도움말ToolStripButton
            // 
            this.도움말ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.도움말ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("도움말ToolStripButton.Image")));
            this.도움말ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.도움말ToolStripButton.Name = "도움말ToolStripButton";
            this.도움말ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.도움말ToolStripButton.Text = "도움말";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 22);
            this.btnBack.Text = "뒤로";
            this.btnBack.Click += new System.EventHandler(this.CmdButton);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(47, 22);
            this.btnForward.Text = "앞으로";
            this.btnForward.Click += new System.EventHandler(this.CmdButton);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(35, 22);
            this.btnGo.Text = "이동";
            this.btnGo.Click += new System.EventHandler(this.CmdButton);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 22);
            this.btnStop.Text = "멈춤";
            this.btnStop.Click += new System.EventHandler(this.CmdButton);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(200, 25);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(878, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "법정동찾기주소";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(996, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // SearchAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 881);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroTile1);
            this.Name = "SearchAreaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchAreaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 새로만들기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 열기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 저장ToolStripButton;
        private System.Windows.Forms.ToolStripButton 인쇄ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 잘라내기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 복사ToolStripButton;
        private System.Windows.Forms.ToolStripButton 붙여넣기ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 도움말ToolStripButton;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}