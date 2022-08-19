using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfMovieFinder.Helpers;

namespace WpfMovieFinder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Dictionary<string, string> configs; 

            using (StreamReader r = new StreamReader("Configs/config.json"))
            {
                string json = r.ReadToEnd();
                configs = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }

            string tmp = string.Empty;
            {
                tmp += $"Data Source={configs["Data_Source"]};";
                tmp += $"Initial Catalog={configs["Initial_Catalog"]};";
                tmp += "Persist Security Info=True;";
                tmp += $"User ID={configs["User_ID"]};";
                tmp += $"Password={configs["Password"]};";
            }

            Commons.CONNSTRING = tmp;

            tmp = string.Empty;
            tmp = $"http://www.omdbapi.com/?apikey={configs["apikey"]}";

            Commons.APIKEYURLSTRING = tmp;

            base.OnStartup(e);
        }
    }
}
