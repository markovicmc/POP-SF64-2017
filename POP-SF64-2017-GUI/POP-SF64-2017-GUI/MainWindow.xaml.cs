﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POP_SF64_2017_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OsveziPrikaz()
        {
            listBoxNamestaj.Items.Clear(); //ocistimo ceo ispis, pristupamo listi

            foreach (var namestaj in Projekat.Instance.Namestaj)
            {
                listBoxNamestaj.Items.Add(namestaj);
            }

        }

    }
}
