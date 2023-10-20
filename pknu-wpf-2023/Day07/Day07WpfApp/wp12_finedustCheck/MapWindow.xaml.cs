﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wp12_finedustCheck
{
    /// <summary>
    /// MapWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MapWindow : MetroWindow
    {
        public MapWindow()
        {
            InitializeComponent();
        }

        public MapWindow(double coordy, double coordx) : this()
        {
            BrsLocSensor.Address = $"https://google.com/maps/place/{coordy},{coordx}";
        }
    }
}
