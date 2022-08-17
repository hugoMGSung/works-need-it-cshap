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

namespace TravelInfoApp
{
    public partial class Infomation : MetroForm
    {
        public Infomation(string str)
        {
            InitializeComponent();
            LbStr.Text = str;
        }
    }
}
