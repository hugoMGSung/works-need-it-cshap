﻿
namespace StudyHistroyApp
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
            this.TrvList = new System.Windows.Forms.TreeView();
            this.PcbPhoto = new System.Windows.Forms.PictureBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TrvList
            // 
            this.TrvList.Location = new System.Drawing.Point(12, 12);
            this.TrvList.Name = "TrvList";
            this.TrvList.Size = new System.Drawing.Size(296, 429);
            this.TrvList.TabIndex = 0;
            this.TrvList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvList_AfterSelect);
            // 
            // PcbPhoto
            // 
            this.PcbPhoto.Location = new System.Drawing.Point(314, 12);
            this.PcbPhoto.Name = "PcbPhoto";
            this.PcbPhoto.Size = new System.Drawing.Size(288, 273);
            this.PcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbPhoto.TabIndex = 1;
            this.PcbPhoto.TabStop = false;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(314, 291);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(288, 150);
            this.TxtDescription.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 453);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.PcbPhoto);
            this.Controls.Add(this.TrvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "영국군주 리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TrvList;
        private System.Windows.Forms.PictureBox PcbPhoto;
        private System.Windows.Forms.TextBox TxtDescription;
    }
}

