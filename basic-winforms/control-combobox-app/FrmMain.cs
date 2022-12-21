using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace control_combobox_app
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] apis = { "Google", "Naver", "Kakao", "Facebook", "Data Portal" };

            // 각 콤보박스에 데이터를 초기화
            CboSimple.Items.AddRange(apis);
            CboDropdown.Items.AddRange(apis);
            //CboDropdownlist.Items.AddRange(apis);

            //CboDropdownlist.Items.Clear();
            //CboDropdownlist.Items.Add("FireMan");
            //CboDropdownlist.Items.AddRange(new[] { "PoliceMan", "OilMan", "PushMan" });
            SetComboboxFromDataSet();

            // 처음 선택값 지정. 첫째 아이템 선택
            CboSimple.SelectedIndex = 0;
            CboDropdown.SelectedIndex = 1;
            CboDropdownlist.SelectedIndex = 2;
        }

        private void SetComboboxFromDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("Codes");

            ds.Tables["Codes"].Columns.Add("Id");
            ds.Tables["Codes"].Columns.Add("Name");

            DataRow dr = ds.Tables["Codes"].NewRow();
            dr["Id"] = "A0001";
            dr["Name"] = "Temperature";
            ds.Tables["Codes"].Rows.Add(dr);
            ds.Tables["Codes"].AcceptChanges();

            dr = ds.Tables["Codes"].NewRow();
            dr["Id"] = "A0002";
            dr["Name"] = "Humidity";
            ds.Tables["Codes"].Rows.Add(dr);
            ds.Tables["Codes"].AcceptChanges();

            dr = ds.Tables["Codes"].NewRow();
            dr["Id"] = "A0003";
            dr["Name"] = "Pressure";
            ds.Tables["Codes"].Rows.Add(dr);
            ds.Tables["Codes"].AcceptChanges();

            CboDropdownlist.DataSource = ds.Tables[0];
            CboDropdownlist.DisplayMember = "Name";
            CboDropdownlist.ValueMember = "Id";
        }

        private void CboDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LblSelectedValue.Text = CboDropdownlist.SelectedValue as String;
        }

        private void CboDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboDropdown.SelectedIndex >= 0)
            {
                this.LblSelected.Text = CboDropdown.SelectedItem as string;
            }
        }
    }
}
