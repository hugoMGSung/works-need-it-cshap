namespace MyStockAdvisor.SubScreen
{
    partial class WebScreen
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
            this.PnlBrowser = new MetroSet_UI.Controls.MetroSetPanel();
            this.PgbImageDownload = new System.Windows.Forms.ProgressBar();
            this.BgwImageDown = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBrowser
            // 
            this.PnlBrowser.BackgroundColor = System.Drawing.Color.White;
            this.PnlBrowser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PnlBrowser.BorderThickness = 1;
            this.PnlBrowser.Controls.Add(this.pictureBox1);
            this.PnlBrowser.Controls.Add(this.PgbImageDownload);
            this.PnlBrowser.Location = new System.Drawing.Point(23, 63);
            this.PnlBrowser.Name = "PnlBrowser";
            this.PnlBrowser.Size = new System.Drawing.Size(648, 569);
            this.PnlBrowser.Style = MetroSet_UI.Design.Style.Light;
            this.PnlBrowser.StyleManager = null;
            this.PnlBrowser.TabIndex = 0;
            this.PnlBrowser.ThemeAuthor = "Narwin";
            this.PnlBrowser.ThemeName = "MetroLite";
            // 
            // PgbImageDownload
            // 
            this.PgbImageDownload.Location = new System.Drawing.Point(16, 14);
            this.PgbImageDownload.Name = "PgbImageDownload";
            this.PgbImageDownload.Size = new System.Drawing.Size(617, 38);
            this.PgbImageDownload.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 498);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WebScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 655);
            this.Controls.Add(this.PnlBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebScreen";
            this.Resizable = false;
            this.Text = "Image Download";
            this.Load += new System.EventHandler(this.WebScreen_Load);
            this.Shown += new System.EventHandler(this.WebScreen_Shown);
            this.PnlBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel PnlBrowser;
        private System.ComponentModel.BackgroundWorker BgwImageDown;
        private System.Windows.Forms.ProgressBar PgbImageDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}