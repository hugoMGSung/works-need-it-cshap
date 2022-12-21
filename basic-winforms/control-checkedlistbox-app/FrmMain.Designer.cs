namespace control_checkedlistbox_app
{
    partial class FrmMain
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
            this.ClbHiddenMenus = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClbHiddenMenus
            // 
            this.ClbHiddenMenus.FormattingEnabled = true;
            this.ClbHiddenMenus.Items.AddRange(new object[] {
            "파일",
            "편집",
            "보기",
            "프로젝트",
            "빌드",
            "디버그",
            "서식",
            "테스트",
            "분석",
            "도구",
            "도움말"});
            this.ClbHiddenMenus.Location = new System.Drawing.Point(14, 100);
            this.ClbHiddenMenus.Name = "ClbHiddenMenus";
            this.ClbHiddenMenus.Size = new System.Drawing.Size(283, 224);
            this.ClbHiddenMenus.TabIndex = 0;
            this.ClbHiddenMenus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbHiddenMenus_ItemCheck);
            this.ClbHiddenMenus.SelectedIndexChanged += new System.EventHandler(this.ClbHiddenMenus_SelectedIndexChanged);
            this.ClbHiddenMenus.SelectedValueChanged += new System.EventHandler(this.ClbHiddenMenus_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "숨길 메뉴 리스트";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClbHiddenMenus);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmMain";
            this.Text = "메뉴관리";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbHiddenMenus;
        private System.Windows.Forms.Label label1;
    }
}

