﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (RdbKorea.Checked == false && RdbChina.Checked == false &&
                RdbJapan.Checked == false && RdbOthers.Checked == false)
            {
                MessageBox.Show("국가를 선택하세요");
                return;
            }          

            if (RdbMale.Checked == false && RdbFemale.Checked == false)
            {
                MessageBox.Show("성별을 선택하세요");
                return;
            }              

            if (RdbKorea.Checked == true)
                result = "국적 : 대한민국\n";
            else if (RdbChina.Checked)
                result = "국적 : 중국\n";
            else if (RdbJapan.Checked)
                result = "국적 : 일본\n";
            else if (RdbOthers.Enabled)
                result = "국적 : 그 외 국가\n";

            if (RdbMale.Checked)
                result += "성별 : 남자";
            else if (RdbFemale.Checked)
                result += "성별 : 여자";

            MessageBox.Show(result, "결과");
        }
    }
}
