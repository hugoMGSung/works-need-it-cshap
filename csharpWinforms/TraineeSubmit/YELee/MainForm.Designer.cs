namespace MyMovieApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtlTitle = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlTitle
            // 
            this.MtlTitle.ActiveControl = null;
            this.MtlTitle.Location = new System.Drawing.Point(23, 89);
            this.MtlTitle.Name = "MtlTitle";
            this.MtlTitle.Size = new System.Drawing.Size(200, 100);
            this.MtlTitle.Style = MetroFramework.MetroColorStyle.Silver;
            this.MtlTitle.TabIndex = 0;
            this.MtlTitle.Text = "영화제목검색";
            this.MtlTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MtlTitle.UseSelectable = true;
            this.MtlTitle.Click += new System.EventHandler(this.MtlTitle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.MtlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Box Office";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlTitle;
    }
}

