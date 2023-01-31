using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace control_textbox_app
{
    public partial class FrmRichTextBox : Form
    {
        public FrmRichTextBox()
        {
            InitializeComponent();
        }

        private void FrmRichTextBox_Load(object sender, EventArgs e)
        {
            txtLoadFile.Text = $"C:\\Users\\perso\\Documents\\ThirdPartyNotices.rtf";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var filePath = txtLoadFile.Text ;
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath) ) {
                MessageBox.Show("Invalid file name");
                return;
            }

            rtbContents.LoadFile(filePath) ;
        }

        private void btnBoldAll_Click(object sender, EventArgs e)
        {
            rtbContents.SelectionStart = 0;
            rtbContents.SelectionLength = rtbContents.Text.Length;
            rtbContents.SelectionFont = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
        }

        int iFindStartIndex = 0;

        private void btnSearchText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchText.Text))
            {
                MessageBox.Show("Input a search word");
                return;
            }

            int iFindLength = txtSearchText.Text.Length;
            iFindStartIndex = FindMyText(txtSearchText.Text, iFindStartIndex, rtbContents.Text.Length);
            if (iFindStartIndex == -1)
            {
                iFindStartIndex = 0;
                return;
            }

            //찾은 문자열 선택해서 붉은색으로 바꾸기
            rtbContents.SelectionColor = Color.Red;
            rtbContents.Select(iFindStartIndex, iFindLength);

            //다음 찾기를 위해 찾은 문자열 위치 저장
            iFindStartIndex += iFindLength;
        }

        private int FindMyText(string searchWord, int indStart, int indEnd)
        {
            // Initialize the return value to false by default.
            int returnValue = -1;

            // Ensure that a search string and a valid starting point are specified.
            if (searchWord.Length > 0 && indStart >= 0)
            {
                // Ensure that a valid ending value is provided.
                if (indEnd > indStart || indEnd == -1)
                {
                    // Obtain the location of the search string in richTextBox1.
                    int indexToText = rtbContents.Find(searchWord, indStart, indEnd, RichTextBoxFinds.MatchCase);
                    // Determine whether the text was found in richTextBox1.
                    if (indexToText >= 0)
                    {
                        // Return the index to the specified search text.
                        returnValue = indexToText;
                    }
                }
            }

            return returnValue;
        }
    }
}
