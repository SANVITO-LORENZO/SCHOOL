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
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("file.txt");
            // per entrare in append
            //StreamWriter sw = new StreamWriter("file.txt",true);
            sw.WriteLine(t.Text);
            sw.Close();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("file.txt");
            string contenuto= sr.ReadToEnd();
            sr.Close();
            t2.Text = contenuto;
        }
    }
}
