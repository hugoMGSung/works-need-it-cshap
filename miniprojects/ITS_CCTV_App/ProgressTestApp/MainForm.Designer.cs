
namespace ProgressTestApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressIndicator = new ProgressControls.ProgressIndicator();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressIndicator
            // 
            this.progressIndicator.Location = new System.Drawing.Point(12, 12);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Percentage = 0F;
            this.progressIndicator.ShowText = true;
            this.progressIndicator.Size = new System.Drawing.Size(296, 296);
            this.progressIndicator.TabIndex = 0;
            this.progressIndicator.TextDisplay = ProgressControls.TextDisplayModes.Text;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressIndicator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressControls.ProgressIndicator progressIndicator;
        private System.Windows.Forms.Button button1;
    }
}

