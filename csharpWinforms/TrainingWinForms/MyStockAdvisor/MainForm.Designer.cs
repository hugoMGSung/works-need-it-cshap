namespace MyStockAdvisor
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
            this.MtlAddress = new MetroFramework.Controls.MetroTile();
            this.MtlInfoAnal = new MetroFramework.Controls.MetroTile();
            this.MtlHealthInfo = new MetroFramework.Controls.MetroTile();
            this.MtlInvestSimul = new MetroFramework.Controls.MetroTile();
            this.MtlGalmetgilCourse = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlAddress
            // 
            this.MtlAddress.Location = new System.Drawing.Point(651, 259);
            this.MtlAddress.Name = "MtlAddress";
            this.MtlAddress.Size = new System.Drawing.Size(150, 150);
            this.MtlAddress.Style = MetroFramework.MetroColorStyle.Pink;
            this.MtlAddress.TabIndex = 3;
            this.MtlAddress.Text = "주소검색";
            this.MtlAddress.TileImage = global::MyStockAdvisor.Properties.Resources.map2;
            this.MtlAddress.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlAddress.UseTileImage = true;
            this.MtlAddress.Click += new System.EventHandler(this.MtlAddress_Click);
            // 
            // MtlInfoAnal
            // 
            this.MtlInfoAnal.Location = new System.Drawing.Point(345, 103);
            this.MtlInfoAnal.Name = "MtlInfoAnal";
            this.MtlInfoAnal.Size = new System.Drawing.Size(150, 150);
            this.MtlInfoAnal.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlInfoAnal.TabIndex = 3;
            this.MtlInfoAnal.Text = "주식정보분석";
            this.MtlInfoAnal.TileImage = global::MyStockAdvisor.Properties.Resources.analysis2;
            this.MtlInfoAnal.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInfoAnal.UseTileImage = true;
            this.MtlInfoAnal.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MtlHealthInfo
            // 
            this.MtlHealthInfo.Location = new System.Drawing.Point(807, 103);
            this.MtlHealthInfo.Name = "MtlHealthInfo";
            this.MtlHealthInfo.Size = new System.Drawing.Size(300, 150);
            this.MtlHealthInfo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.MtlHealthInfo.TabIndex = 3;
            this.MtlHealthInfo.Text = "체력인증센터 정보";
            this.MtlHealthInfo.TileImage = global::MyStockAdvisor.Properties.Resources.cross2;
            this.MtlHealthInfo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlHealthInfo.UseTileImage = true;
            this.MtlHealthInfo.Click += new System.EventHandler(this.MtlHealthInfo_Click);
            // 
            // MtlInvestSimul
            // 
            this.MtlInvestSimul.Location = new System.Drawing.Point(345, 259);
            this.MtlInvestSimul.Name = "MtlInvestSimul";
            this.MtlInvestSimul.Size = new System.Drawing.Size(300, 150);
            this.MtlInvestSimul.Style = MetroFramework.MetroColorStyle.Green;
            this.MtlInvestSimul.TabIndex = 3;
            this.MtlInvestSimul.Text = "투자시뮬레이션";
            this.MtlInvestSimul.TileImage = global::MyStockAdvisor.Properties.Resources.simulator2;
            this.MtlInvestSimul.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInvestSimul.UseTileImage = true;
            this.MtlInvestSimul.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MtlGalmetgilCourse
            // 
            this.MtlGalmetgilCourse.Location = new System.Drawing.Point(501, 103);
            this.MtlGalmetgilCourse.Name = "MtlGalmetgilCourse";
            this.MtlGalmetgilCourse.Size = new System.Drawing.Size(300, 150);
            this.MtlGalmetgilCourse.Style = MetroFramework.MetroColorStyle.Purple;
            this.MtlGalmetgilCourse.TabIndex = 3;
            this.MtlGalmetgilCourse.Text = "갈맷길정보";
            this.MtlGalmetgilCourse.TileImage = global::MyStockAdvisor.Properties.Resources.feather2;
            this.MtlGalmetgilCourse.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlGalmetgilCourse.UseTileImage = true;
            this.MtlGalmetgilCourse.Click += new System.EventHandler(this.MtlGalmetgilCourse_Click);
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(39, 103);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(300, 150);
            this.MtlSearchItem.Style = MetroFramework.MetroColorStyle.Teal;
            this.MtlSearchItem.TabIndex = 3;
            this.MtlSearchItem.Text = "주식검색";
            this.MtlSearchItem.TileImage = global::MyStockAdvisor.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlAddress);
            this.Controls.Add(this.MtlInfoAnal);
            this.Controls.Add(this.MtlHealthInfo);
            this.Controls.Add(this.MtlInvestSimul);
            this.Controls.Add(this.MtlGalmetgilCourse);
            this.Controls.Add(this.MtlSearchItem);
            this.Font = new System.Drawing.Font("나눔고딕", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12, 61, 12, 10);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식분석시스템";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlInfoAnal;
        private MetroFramework.Controls.MetroTile MtlInvestSimul;
        private MetroFramework.Controls.MetroTile MtlGalmetgilCourse;
        private MetroFramework.Controls.MetroTile MtlAddress;
        private MetroFramework.Controls.MetroTile MtlHealthInfo;
    }
}

