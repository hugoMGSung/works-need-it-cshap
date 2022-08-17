using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strTemp = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                strTemp += item.ToString() + " ";                
            }
            MessageBox.Show($"당신의 취미는 {strTemp} 입니다.", "확인", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 3)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("최대 선택 개수는 3개입니다.");
            }
        }
    }
}
