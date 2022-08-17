using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttMonitorApp
{
    public partial class MainForm : MetroSetForm
    {
        public string ConnString { get; set; }
        public MainForm()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            ConnString = "Server=localhost;Port=3306;" +
                         "Database=iot_data;Uid=root;Pwd=mysql_p@ssw0rd";
            TxtConnString.Text = ConnString;
        }
    }
}
