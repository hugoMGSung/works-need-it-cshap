
namespace ITS_CCTV_App
{
    partial class LoadingForm
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
            this.Indicator = new ProgressControls.ProgressIndicator();
            this.SuspendLayout();
            // 
            // Indicator
            // 
            this.Indicator.CircleSize = 0.6F;
            this.Indicator.Location = new System.Drawing.Point(12, 12);
            this.Indicator.Name = "Indicator";
            this.Indicator.NumberOfCircles = 17;
            this.Indicator.NumberOfVisibleCircles = 15;
            this.Indicator.Percentage = 0F;
            this.Indicator.Size = new System.Drawing.Size(316, 316);
            this.Indicator.TabIndex = 0;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.Indicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressControls.ProgressIndicator Indicator;
    }
}