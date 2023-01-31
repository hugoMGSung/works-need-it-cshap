namespace control_checkbox_app
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoTeens = new System.Windows.Forms.RadioButton();
            this.rdoTwenties = new System.Windows.Forms.RadioButton();
            this.rdoThirties = new System.Windows.Forms.RadioButton();
            this.rdoFourties = new System.Windows.Forms.RadioButton();
            this.rdoFifthies = new System.Windows.Forms.RadioButton();
            this.rdoSixties = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSixties);
            this.groupBox2.Controls.Add(this.rdoFifthies);
            this.groupBox2.Controls.Add(this.rdoFourties);
            this.groupBox2.Controls.Add(this.rdoThirties);
            this.groupBox2.Controls.Add(this.rdoTwenties);
            this.groupBox2.Controls.Add(this.rdoTeens);
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "연령대";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(236, 219);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 34);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(19, 34);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(57, 21);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "남성";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(19, 61);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(57, 21);
            this.rdoFemale.TabIndex = 0;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "여성";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoTeens
            // 
            this.rdoTeens.AutoSize = true;
            this.rdoTeens.Location = new System.Drawing.Point(16, 34);
            this.rdoTeens.Name = "rdoTeens";
            this.rdoTeens.Size = new System.Drawing.Size(61, 21);
            this.rdoTeens.TabIndex = 1;
            this.rdoTeens.TabStop = true;
            this.rdoTeens.Text = "10대";
            this.rdoTeens.UseVisualStyleBackColor = true;
            // 
            // rdoTwenties
            // 
            this.rdoTwenties.AutoSize = true;
            this.rdoTwenties.Location = new System.Drawing.Point(16, 61);
            this.rdoTwenties.Name = "rdoTwenties";
            this.rdoTwenties.Size = new System.Drawing.Size(61, 21);
            this.rdoTwenties.TabIndex = 1;
            this.rdoTwenties.TabStop = true;
            this.rdoTwenties.Text = "20대";
            this.rdoTwenties.UseVisualStyleBackColor = true;
            // 
            // rdoThirties
            // 
            this.rdoThirties.AutoSize = true;
            this.rdoThirties.Location = new System.Drawing.Point(16, 88);
            this.rdoThirties.Name = "rdoThirties";
            this.rdoThirties.Size = new System.Drawing.Size(61, 21);
            this.rdoThirties.TabIndex = 1;
            this.rdoThirties.TabStop = true;
            this.rdoThirties.Text = "30대";
            this.rdoThirties.UseVisualStyleBackColor = true;
            // 
            // rdoFourties
            // 
            this.rdoFourties.AutoSize = true;
            this.rdoFourties.Location = new System.Drawing.Point(16, 115);
            this.rdoFourties.Name = "rdoFourties";
            this.rdoFourties.Size = new System.Drawing.Size(61, 21);
            this.rdoFourties.TabIndex = 1;
            this.rdoFourties.TabStop = true;
            this.rdoFourties.Text = "40대";
            this.rdoFourties.UseVisualStyleBackColor = true;
            // 
            // rdoFifthies
            // 
            this.rdoFifthies.AutoSize = true;
            this.rdoFifthies.Location = new System.Drawing.Point(16, 142);
            this.rdoFifthies.Name = "rdoFifthies";
            this.rdoFifthies.Size = new System.Drawing.Size(61, 21);
            this.rdoFifthies.TabIndex = 1;
            this.rdoFifthies.TabStop = true;
            this.rdoFifthies.Text = "50대";
            this.rdoFifthies.UseVisualStyleBackColor = true;
            // 
            // rdoSixties
            // 
            this.rdoSixties.AutoSize = true;
            this.rdoSixties.Location = new System.Drawing.Point(16, 169);
            this.rdoSixties.Name = "rdoSixties";
            this.rdoSixties.Size = new System.Drawing.Size(61, 21);
            this.rdoSixties.TabIndex = 1;
            this.rdoSixties.TabStop = true;
            this.rdoSixties.Text = "60대";
            this.rdoSixties.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form2";
            this.Text = "라디오버튼 예제";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSixties;
        private System.Windows.Forms.RadioButton rdoFifthies;
        private System.Windows.Forms.RadioButton rdoFourties;
        private System.Windows.Forms.RadioButton rdoThirties;
        private System.Windows.Forms.RadioButton rdoTwenties;
        private System.Windows.Forms.RadioButton rdoTeens;
        private System.Windows.Forms.Button btnCheck;
    }
}