using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_checkedlistbox_app
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClbHiddenMenus.SetItemChecked(2, true); // 보기
            ClbHiddenMenus.SetItemChecked(5, true); // 디버그 
        }

        private void ClbHiddenMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("2. 뒤에 발생합니다.");

            var items = ClbHiddenMenus.CheckedItems;
            var selectedItems = string.Empty;

            foreach (var item in items)
            {
                selectedItems += item.ToString() + "\n";
            }

            MessageBox.Show(selectedItems, "선택된 숨길 메뉴", MessageBoxButtons.OK);
        }

        private void ClbHiddenMenus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Debug.WriteLine("1. 먼저 발생합니다.");
        }

        private void ClbHiddenMenus_SelectedValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("0. 맨먼저 발생합니다.");

            int index = ClbHiddenMenus.SelectedIndex;

            if (ClbHiddenMenus.GetItemChecked(index))
            {
                ClbHiddenMenus.SetItemChecked(index, false);
            }
            else
            {
                ClbHiddenMenus.SetItemChecked(index, true);
            }
        }
    }
}
