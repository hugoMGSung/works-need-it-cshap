﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMdiApp
{
    public partial class FrmMain : Form
    {
        FrmChild frmChild = null;
        FrmSub frmSub = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "창 " + childFormNumber++;
            //childForm.Show();
            if (this.ActiveMdiChild != null) // 자식폼이 열려 있으면
            {
                // 열려있는 자식폼이 FrmChild 이 아니면
                if (this.ActiveMdiChild != frmChild)
                {
                    ActiveMdiChild.Close(); // 현재 활성화된 창을 종료
                }

                frmChild = ShowActiveForm(frmChild, typeof(FrmChild)) as FrmChild;
            }
            else
            {
                frmChild = ShowActiveForm(frmChild, typeof(FrmChild)) as FrmChild;
            }
        }

        private Form ShowActiveForm(Form form, Type type)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Normal;
                form.Show();
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(type);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }

            return form;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
            if (this.ActiveMdiChild != null) // 자식폼이 열려 있으면
            {
                // 열려있는 자식폼이 FrmChild 이 아니면
                if (this.ActiveMdiChild != frmSub)
                {
                    ActiveMdiChild.Close(); // 현재 활성화된 창을 종료
                }
                frmSub = ShowActiveForm(frmSub, typeof(FrmSub)) as FrmSub;
            }
            else
            {
                frmSub = ShowActiveForm(frmSub, typeof(FrmSub)) as FrmSub;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
