using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thursday.SearchArea;
using thursday.TradeFigure;

namespace thursday
{
    public partial class formq : MetroForm
    {
        public formq()
        {
            InitializeComponent();
            this.Location = new Point(
            Screen.PrimaryScreen.Bounds.Width / 2,
            Screen.PrimaryScreen.Bounds.Height / 2);
        }

        private void formq_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchAreaForm searchArea = new SearchAreaForm();
            searchArea.Location = this.Location;
            searchArea.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TradeFigureForm tradeForm = new TradeFigureForm();
            tradeForm.Location = this.Location;
            tradeForm.ShowDialog();
            this.Close();
        }
    }
}
