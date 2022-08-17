namespace UsingControls
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
            this.FontGroupBox = new System.Windows.Forms.GroupBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFonts = new System.Windows.Forms.ComboBox();
            this.LblFont = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrbBasic = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // FontGroupBox
            // 
            this.FontGroupBox.Controls.Add(this.TxtResult);
            this.FontGroupBox.Controls.Add(this.ChkItalic);
            this.FontGroupBox.Controls.Add(this.ChkBold);
            this.FontGroupBox.Controls.Add(this.CboFonts);
            this.FontGroupBox.Controls.Add(this.LblFont);
            this.FontGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FontGroupBox.Name = "FontGroupBox";
            this.FontGroupBox.Size = new System.Drawing.Size(457, 82);
            this.FontGroupBox.TabIndex = 0;
            this.FontGroupBox.TabStop = false;
            this.FontGroupBox.Text = "Font Group";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(8, 43);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(403, 21);
            this.TxtResult.TabIndex = 1;
            this.TxtResult.Text = "Hello, C#";
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkItalic.Location = new System.Drawing.Point(277, 21);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(60, 16);
            this.ChkItalic.TabIndex = 5;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkBold.Location = new System.Drawing.Point(221, 21);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 16);
            this.ChkBold.TabIndex = 4;
            this.ChkBold.Text = "굵게";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // CboFonts
            // 
            this.CboFonts.FormattingEnabled = true;
            this.CboFonts.Location = new System.Drawing.Point(50, 17);
            this.CboFonts.Name = "CboFonts";
            this.CboFonts.Size = new System.Drawing.Size(165, 20);
            this.CboFonts.TabIndex = 3;
            this.CboFonts.SelectedIndexChanged += new System.EventHandler(this.CboFonts_SelectedIndexChanged);
            // 
            // LblFont
            // 
            this.LblFont.AutoSize = true;
            this.LblFont.Location = new System.Drawing.Point(6, 20);
            this.LblFont.Name = "LblFont";
            this.LblFont.Size = new System.Drawing.Size(37, 12);
            this.LblFont.TabIndex = 2;
            this.LblFont.Text = "폰트 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.TrbBasic);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track/Progress Bar";
            // 
            // TrbBasic
            // 
            this.TrbBasic.Location = new System.Drawing.Point(8, 20);
            this.TrbBasic.Maximum = 40;
            this.TrbBasic.Name = "TrbBasic";
            this.TrbBasic.Size = new System.Drawing.Size(443, 45);
            this.TrbBasic.TabIndex = 0;
            this.TrbBasic.Scroll += new System.EventHandler(this.TrbBasic_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(422, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(62, 230);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 21);
            this.TxtValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "결과 : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 344);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FontGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Control Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FontGroupBox.ResumeLayout(false);
            this.FontGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBasic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FontGroupBox;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.ComboBox CboFonts;
        private System.Windows.Forms.Label LblFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar TrbBasic;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label label1;
    }
}

