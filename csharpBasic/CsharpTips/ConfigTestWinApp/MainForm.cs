using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ConfigTestWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MyConfig> configs = new List<MyConfig>();

            configs.Add(new MyConfig { Key = "SecurityLevel", Value = ConfigurationManager.AppSettings["SecurityLevel"] });
            configs.Add(new MyConfig { Key = "Locale", Value = ConfigurationManager.AppSettings["Locale"] });

            configs.Add(new MyConfig { Key = "TestDBConnectionString", Value = ConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString });
            dataGridView1.DataSource = configs;

            dataGridView1.Columns[0].Width = 190;
            dataGridView1.Columns[1].Width = 540;
        }
    }
}
