
namespace ITS_CCTV_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtItsSearch = new System.Windows.Forms.TextBox();
            this.LbxItsCctv = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtExSearch = new System.Windows.Forms.TextBox();
            this.LbxExCctv = new System.Windows.Forms.ListBox();
            this.TxtCctvUrl = new System.Windows.Forms.TextBox();
            this.VlcCctv = new Vlc.DotNet.Forms.VlcControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VlcCctv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 558);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 192);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtItsSearch);
            this.groupBox2.Controls.Add(this.LbxItsCctv);
            this.groupBox2.Location = new System.Drawing.Point(3, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "국도";
            // 
            // TxtItsSearch
            // 
            this.TxtItsSearch.Location = new System.Drawing.Point(7, 27);
            this.TxtItsSearch.Name = "TxtItsSearch";
            this.TxtItsSearch.Size = new System.Drawing.Size(274, 27);
            this.TxtItsSearch.TabIndex = 1;
            this.TxtItsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItsSearch_KeyDown);
            // 
            // LbxItsCctv
            // 
            this.LbxItsCctv.FormattingEnabled = true;
            this.LbxItsCctv.ItemHeight = 20;
            this.LbxItsCctv.Location = new System.Drawing.Point(6, 60);
            this.LbxItsCctv.Name = "LbxItsCctv";
            this.LbxItsCctv.Size = new System.Drawing.Size(275, 104);
            this.LbxItsCctv.TabIndex = 0;
            this.LbxItsCctv.SelectedIndexChanged += new System.EventHandler(this.LbxItsCctv_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtExSearch);
            this.groupBox1.Controls.Add(this.LbxExCctv);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "고속도로";
            // 
            // TxtExSearch
            // 
            this.TxtExSearch.Location = new System.Drawing.Point(7, 30);
            this.TxtExSearch.Name = "TxtExSearch";
            this.TxtExSearch.Size = new System.Drawing.Size(274, 27);
            this.TxtExSearch.TabIndex = 2;
            this.TxtExSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtExSearch_KeyDown);
            // 
            // LbxExCctv
            // 
            this.LbxExCctv.FormattingEnabled = true;
            this.LbxExCctv.ItemHeight = 20;
            this.LbxExCctv.Location = new System.Drawing.Point(7, 63);
            this.LbxExCctv.Name = "LbxExCctv";
            this.LbxExCctv.Size = new System.Drawing.Size(275, 104);
            this.LbxExCctv.TabIndex = 0;
            this.LbxExCctv.SelectedIndexChanged += new System.EventHandler(this.LbxExCctv_SelectedIndexChanged);
            // 
            // TxtCctvUrl
            // 
            this.TxtCctvUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCctvUrl.Location = new System.Drawing.Point(311, 12);
            this.TxtCctvUrl.Name = "TxtCctvUrl";
            this.TxtCctvUrl.ReadOnly = true;
            this.TxtCctvUrl.Size = new System.Drawing.Size(877, 27);
            this.TxtCctvUrl.TabIndex = 2;
            // 
            // VlcCctv
            // 
            this.VlcCctv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VlcCctv.BackColor = System.Drawing.Color.Black;
            this.VlcCctv.Location = new System.Drawing.Point(311, 45);
            this.VlcCctv.Name = "VlcCctv";
            this.VlcCctv.Size = new System.Drawing.Size(877, 525);
            this.VlcCctv.Spu = -1;
            this.VlcCctv.TabIndex = 3;
            this.VlcCctv.Text = "vlcControl1";
            this.VlcCctv.VlcLibDirectory = null;
            this.VlcCctv.VlcMediaplayerOptions = null;
            this.VlcCctv.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VlcCctv_VlcLibDirectoryNeeded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 582);
            this.Controls.Add(this.VlcCctv);
            this.Controls.Add(this.TxtCctvUrl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VlcCctv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LbxItsCctv;
        private System.Windows.Forms.ListBox LbxExCctv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtCctvUrl;
        private Vlc.DotNet.Forms.VlcControl VlcCctv;
        private System.Windows.Forms.TextBox TxtItsSearch;
        private System.Windows.Forms.TextBox TxtExSearch;
    }
}

