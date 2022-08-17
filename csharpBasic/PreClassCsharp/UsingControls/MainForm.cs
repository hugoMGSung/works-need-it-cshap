using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }
        }

        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0)
            {
                return;
            }
            FontStyle style = FontStyle.Regular; // style = FontStyle.Regular
            if (ChkBold.Checked)
            {
                style |= FontStyle.Bold; // style = FontStyle.Regular or FontStyle.Bold
            }
            if (ChkItalic.Checked)
            {
                style |= FontStyle.Italic; // style = FontStyle.Regular & FontStyle.Italic
            }
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 10, style);
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbBasic_Scroll(object sender, EventArgs e)
        {
            TxtValue.Text = TrbBasic.Value.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
            TxtValue.Text = progressBar1.Value.ToString();
        }
    }

    
}
