using MetroFramework.Forms;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStockAdvisor
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.Location = new Point(
                    Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                    Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
                );
        }

        private void MtlSearchItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchItemForm searchItem = new SearchItemForm();
            searchItem.Location = this.Location;
            searchItem.ShowDialog();

            this.Close();
        }

        private void MtlGalmetgilCourse_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            GalmetgilCourseForm galmetgil = new GalmetgilCourseForm();
            galmetgil.Location = this.Location;
            galmetgil.ShowDialog();

            this.Close();
        }

        private void MtlAddress_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchAddressForm searchAddress = new SearchAddressForm();
            searchAddress.Location = this.Location;
            searchAddress.ShowDialog();

            this.Close();
        }

        private void MtlHealthInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            HealthInfoForm healthInfo = new HealthInfoForm();
            healthInfo.Location = this.Location;
            healthInfo.ShowDialog();

            this.Close();
        }
    }
}
