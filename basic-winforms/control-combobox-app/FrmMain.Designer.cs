namespace control_combobox_app
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboSimple = new System.Windows.Forms.ComboBox();
            this.CboDropdown = new System.Windows.Forms.ComboBox();
            this.CboDropdownlist = new System.Windows.Forms.ComboBox();
            this.LblSelected = new System.Windows.Forms.Label();
            this.LblSelectedValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DROPDOWN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DROPDOWNLIST";
            // 
            // CboSimple
            // 
            this.CboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CboSimple.FormattingEnabled = true;
            this.CboSimple.Location = new System.Drawing.Point(39, 99);
            this.CboSimple.Name = "CboSimple";
            this.CboSimple.Size = new System.Drawing.Size(159, 23);
            this.CboSimple.TabIndex = 2;
            // 
            // CboDropdown
            // 
            this.CboDropdown.FormattingEnabled = true;
            this.CboDropdown.Location = new System.Drawing.Point(243, 99);
            this.CboDropdown.Name = "CboDropdown";
            this.CboDropdown.Size = new System.Drawing.Size(159, 25);
            this.CboDropdown.TabIndex = 2;
            this.CboDropdown.SelectedIndexChanged += new System.EventHandler(this.CboDropdown_SelectedIndexChanged);
            // 
            // CboDropdownlist
            // 
            this.CboDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDropdownlist.FormattingEnabled = true;
            this.CboDropdownlist.Location = new System.Drawing.Point(445, 99);
            this.CboDropdownlist.Name = "CboDropdownlist";
            this.CboDropdownlist.Size = new System.Drawing.Size(159, 25);
            this.CboDropdownlist.TabIndex = 2;
            this.CboDropdownlist.SelectedIndexChanged += new System.EventHandler(this.CboDropdownlist_SelectedIndexChanged);
            // 
            // LblSelected
            // 
            this.LblSelected.AutoSize = true;
            this.LblSelected.Location = new System.Drawing.Point(240, 153);
            this.LblSelected.Name = "LblSelected";
            this.LblSelected.Size = new System.Drawing.Size(13, 17);
            this.LblSelected.TabIndex = 1;
            this.LblSelected.Text = "-";
            // 
            // LblSelectedValue
            // 
            this.LblSelectedValue.AutoSize = true;
            this.LblSelectedValue.Location = new System.Drawing.Point(442, 153);
            this.LblSelectedValue.Name = "LblSelectedValue";
            this.LblSelectedValue.Size = new System.Drawing.Size(13, 17);
            this.LblSelectedValue.TabIndex = 1;
            this.LblSelectedValue.Text = "-";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 221);
            this.Controls.Add(this.CboDropdownlist);
            this.Controls.Add(this.CboDropdown);
            this.Controls.Add(this.CboSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSelectedValue);
            this.Controls.Add(this.LblSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmMain";
            this.Text = "API 선택";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboSimple;
        private System.Windows.Forms.ComboBox CboDropdown;
        private System.Windows.Forms.ComboBox CboDropdownlist;
        private System.Windows.Forms.Label LblSelected;
        private System.Windows.Forms.Label LblSelectedValue;
    }
}

