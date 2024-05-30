using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;

namespace FANTACALCIO_2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Giocatore> lista = new List<Giocatore>();
        int tmp = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTT_AGGIUNGI_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            bool? result = ofd.ShowDialog();
            if (result != false && result.HasValue && result == true)
            {
                string nome = ofd.SafeFileName;
                TXT_BOX.Text = nome;
            }
            StreamReader sr = new StreamReader(ofd.SafeFileName);
            for (int i = 0; i < 15; i++) 
            {
                string row = sr.ReadLine();
                lista.Add(Giocatore.parse(row));
                LISTA_GIOCATORI.Items.Add(Giocatore.parse(row));
            }
            sr.Close();
            sr.Dispose();

        }

        private void LISTA_GIOCATORI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tmp++;
            if (tmp <= 11)
            {
                LISTA_TITOLARI.Items.Add((Giocatore)LISTA_GIOCATORI.SelectedItem);
            }

        }

        private void BTT_SALVA_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(TXT_BOX.Text,true);
            sw.WriteLine("------------------------");
            sw.WriteLine("DATA MODIFICA: " + DateTime.Now.ToShortDateString());
            sw.WriteLine("titolari");
            for (int i = 0; i < LISTA_TITOLARI.Items.Count; i++)  {
                sw.WriteLine(LISTA_TITOLARI.Items[i].ToString().Replace(" ",";"));
            }
            if (TXT.Text != string.Empty)
            {
                sw.WriteLine("----------------------------");
                sw.WriteLine("DATA MODIFICA: " + DateTime.Now.ToShortDateString());
                sw.WriteLine(TXT.Text);
            }
            sw.Close();
            sw.Dispose();
        }
    }
}
