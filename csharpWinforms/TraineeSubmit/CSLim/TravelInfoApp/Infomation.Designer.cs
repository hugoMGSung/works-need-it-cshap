namespace TravelInfoApp
{
    partial class Infomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infomation));
            this.LbStr = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LbStr
            // 
            this.LbStr.AutoSize = true;
            this.LbStr.Location = new System.Drawing.Point(23, 60);
            this.LbStr.Name = "LbStr";
            this.LbStr.Size = new System.Drawing.Size(31, 19);
            this.LbStr.TabIndex = 0;
            this.LbStr.Text = "Text";
            // 
            // Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.LbStr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Infomation";
            this.Resizable = false;
            this.Text = "Infomation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LbStr;
    }
}