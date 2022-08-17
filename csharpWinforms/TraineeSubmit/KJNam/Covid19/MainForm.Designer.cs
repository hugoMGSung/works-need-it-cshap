namespace Covid19
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
            this.Total = new MetroFramework.Controls.MetroTile();
            this.Korea = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.ActiveControl = null;
            this.Total.Location = new System.Drawing.Point(362, 170);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(209, 99);
            this.Total.Style = MetroFramework.MetroColorStyle.Purple;
            this.Total.TabIndex = 0;
            this.Total.Text = "해외_코로나_현황";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Total.UseSelectable = true;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // Korea
            // 
            this.Korea.ActiveControl = null;
            this.Korea.Location = new System.Drawing.Point(147, 170);
            this.Korea.Name = "Korea";
            this.Korea.Size = new System.Drawing.Size(209, 99);
            this.Korea.Style = MetroFramework.MetroColorStyle.Red;
            this.Korea.TabIndex = 0;
            this.Korea.Text = "국내_코로나_현황";
            this.Korea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Korea.UseSelectable = true;
            this.Korea.Click += new System.EventHandler(this.Korea_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.Korea);
            this.Controls.Add(this.Total);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Covid19_발생_현황";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Covid19_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile Total;
        private MetroFramework.Controls.MetroTile Korea;
    }
}

