namespace MyStockSystem
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.MtlAnal = new MetroFramework.Controls.MetroTile();
            this.MtlItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(617, 83);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(226, 346);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.TileImage = global::MyStockSystem.Properties.Resources.icon__2_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(56, 259);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(555, 170);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "투자시뮬레이션";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::MyStockSystem.Properties.Resources.simulator2;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseTileImage = true;
            // 
            // MtlAnal
            // 
            this.MtlAnal.Location = new System.Drawing.Point(275, 83);
            this.MtlAnal.Name = "MtlAnal";
            this.MtlAnal.Size = new System.Drawing.Size(336, 170);
            this.MtlAnal.Style = MetroFramework.MetroColorStyle.Pink;
            this.MtlAnal.TabIndex = 2;
            this.MtlAnal.Text = "주식정보분석";
            this.MtlAnal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MtlAnal.TileImage = global::MyStockSystem.Properties.Resources.analysis2;
            this.MtlAnal.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlAnal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlAnal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlAnal.UseTileImage = true;
            // 
            // MtlItem
            // 
            this.MtlItem.Location = new System.Drawing.Point(57, 83);
            this.MtlItem.Name = "MtlItem";
            this.MtlItem.Size = new System.Drawing.Size(212, 170);
            this.MtlItem.TabIndex = 1;
            this.MtlItem.Text = "주식정보검색";
            this.MtlItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MtlItem.TileImage = global::MyStockSystem.Properties.Resources.marketing2;
            this.MtlItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlItem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MtlItem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MtlItem.UseTileImage = true;
            this.MtlItem.Click += new System.EventHandler(this.MtlItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.MtlAnal);
            this.Controls.Add(this.MtlItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "주식분석시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile MtlItem;
        private MetroFramework.Controls.MetroTile MtlAnal;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

