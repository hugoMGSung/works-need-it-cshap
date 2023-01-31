using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_checkbox_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string resGender = string.Empty;
            string resAges = string.Empty;
            if (rdoMale.Checked ) {
                resGender = "남성"; //  rdoMale.Text;
            } else if (rdoFemale.Checked ) {
                resGender = rdoFemale.Text;
            }

            if (rdoTeens.Checked) { resAges = rdoTeens.Text; } 
            else if (rdoTwenties.Checked ) { resAges= rdoTwenties.Text; }
            else if (rdoThirties.Checked ) { resAges = rdoThirties.Text; }
            else if (rdoFourties.Checked ) { resAges = rdoFourties.Text; }
            else if (rdoFifthies.Checked ) { resAges = rdoFifthies.Text; }
            else if (rdoSixties.Checked ) { resAges = rdoSixties.Text;  }

            MessageBox.Show($"성별 : {resGender}" + System.Environment.NewLine +
                            $"연령대 : {resAges}", "결과");
        }
    }
}
