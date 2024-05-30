using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort com;
        public MainWindow()
        {
            InitializeComponent();
            //COMUNICAZIONE SERIALE
            com = new SerialPort("COM3", 9600);
            com.Open();

        }

        private void btt_Click(object sender, RoutedEventArgs e)
        {
            string t = txtbox.Text;
            com.Write(t);
            com.DataReceived += Com_DataReceived;

        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = com.ReadExisting();
            txtbox2.Dispatcher.Invoke(new Action(() =>
            {
                txtbox2.Text = s;
            }));

        }
    }
}
