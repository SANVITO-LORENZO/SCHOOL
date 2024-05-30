using System;
using System.Collections.Generic;
using System.IO;
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

namespace filebinario
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Auto> lista = new List<Auto>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTT_ADD_Click(object sender, RoutedEventArgs e)
        {
            LISTA.Items.Add(new Auto(TXT_TARGA.Text, TXT_DESCRIZIONE.Text, int.Parse(TXT_KM.Text), int.Parse(TXT_PREZZO.Text)));
            lista.Add(new Auto(TXT_TARGA.Text, TXT_DESCRIZIONE.Text, int.Parse(TXT_KM.Text), int.Parse(TXT_PREZZO.Text)));

            using (BinaryWriter writer = new BinaryWriter(File.Open("dati.dat", FileMode.Append)))
            {
                byte[] buffer = null;

                foreach (Auto a in lista)
                {
                    //7 byte
                    buffer = UnicodeEncoding.ASCII.GetBytes(a.Targa);
                    writer.Write(buffer);

                    //50 byte
                    string d = a.Descrizione.PadRight(50, ' ').Substring(0, 50);
                    buffer = UnicodeEncoding.ASCII.GetBytes(d);
                    writer.Write(buffer);

                    //4 byte
                    writer.Write(a.Prezzo);

                    //4 byte
                    writer.Write(a.Km);

                    //Il singolo record occupa 65 byte
                }

                writer.Close();

            }
        }
    }
}
