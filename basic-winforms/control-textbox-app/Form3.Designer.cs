namespace control_textbox_app
{
    partial class FrmRichTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearchText = new System.Windows.Forms.Button();
            this.btnBoldAll = new System.Windows.Forms.Button();
            this.rtbContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load File";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(108, 18);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(361, 25);
            this.txtLoadFile.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(486, 18);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(91, 26);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Text";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(108, 49);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(361, 25);
            this.txtSearchText.TabIndex = 1;
            // 
            // btnSearchText
            // 
            this.btnSearchText.Location = new System.Drawing.Point(486, 49);
            this.btnSearchText.Name = "btnSearchText";
            this.btnSearchText.Size = new System.Drawing.Size(91, 25);
            this.btnSearchText.TabIndex = 2;
            this.btnSearchText.Text = "Search";
            this.btnSearchText.UseVisualStyleBackColor = true;
            this.btnSearchText.Click += new System.EventHandler(this.btnSearchText_Click);
            // 
            // btnBoldAll
            // 
            this.btnBoldAll.Location = new System.Drawing.Point(687, 48);
            this.btnBoldAll.Name = "btnBoldAll";
            this.btnBoldAll.Size = new System.Drawing.Size(91, 25);
            this.btnBoldAll.TabIndex = 2;
            this.btnBoldAll.Text = "Bold All";
            this.btnBoldAll.UseVisualStyleBackColor = true;
            this.btnBoldAll.Click += new System.EventHandler(this.btnBoldAll_Click);
            // 
            // rtbContents
            // 
            this.rtbContents.Location = new System.Drawing.Point(12, 80);
            this.rtbContents.Name = "rtbContents";
            this.rtbContents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbContents.Size = new System.Drawing.Size(765, 350);
            this.rtbContents.TabIndex = 3;
            this.rtbContents.Text = "";
            // 
            // FrmRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 442);
            this.Controls.Add(this.rtbContents);
            this.Controls.Add(this.btnBoldAll);
            this.Controls.Add(this.btnSearchText);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoadFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmRichTextBox";
            this.Text = "RichTextBox 예제";
            this.Load += new System.EventHandler(this.FrmRichTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnSearchText;
        private System.Windows.Forms.Button btnBoldAll;
        private System.Windows.Forms.RichTextBox rtbContents;
    }
}