using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentSelApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CboRestaurent.Items.AddRange(new string[] { 
                "히노아지", "스시야마", "퍼지네이블", "새마을식당", "홍콩반점", "롤링파스타"
            });
        }

        private void CboRestaurent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ComboBox;
            LblResult.Text = $"이번 주 모임장소 : {selItem.SelectedItem}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CboRestaurent.Text != "")
            {
                CboRestaurent.Items.Add(CboRestaurent.Text);
                LblResult.Text = $"{CboRestaurent.Text} 아이템 추가";
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (CboRestaurent.SelectedIndex > -1)
            {
                LblResult.Text = $"{CboRestaurent.SelectedItem} 아이템 삭제";
                CboRestaurent.Items.Remove(CboRestaurent.SelectedItem);                
            }
        }
    }
}
