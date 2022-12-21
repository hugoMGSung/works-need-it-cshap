namespace control_textbox_app
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxBirthday = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일";
            // 
            // mtxBirthday
            // 
            this.mtxBirthday.Location = new System.Drawing.Point(127, 24);
            this.mtxBirthday.Mask = "0000-00-00";
            this.mtxBirthday.Name = "mtxBirthday";
            this.mtxBirthday.Size = new System.Drawing.Size(220, 25);
            this.mtxBirthday.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "스마트폰";
            // 
            // mtxPhoneNumber
            // 
            this.mtxPhoneNumber.Location = new System.Drawing.Point(127, 55);
            this.mtxPhoneNumber.Name = "mtxPhoneNumber";
            this.mtxPhoneNumber.Size = new System.Drawing.Size(220, 25);
            this.mtxPhoneNumber.TabIndex = 2;
            this.mtxPhoneNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxPhoneNumber_MaskInputRejected);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(236, 106);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 38);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 168);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.mtxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxBirthday);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxPhoneNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}