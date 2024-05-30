using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace amiconi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nomefile = "";
        ObservableCollection<amicone> lista = new ObservableCollection<amicone>();  
        public MainWindow()
        {
            InitializeComponent();
            LISTA_1.ItemsSource = lista;
        }

        private void BTT_AGGIUNGI_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            bool? result = ofd.ShowDialog();
            if (result!=false && result.HasValue && result==true )
            {
                nomefile = ofd.SafeFileName;
            }

            StreamReader sr = new StreamReader( nomefile );
            while( !sr.EndOfStream )
            {
                string row = sr.ReadLine();
                lista.Add(amicone.parse(row));
            }

            sr.Close();
            sr.Dispose();
        }

        private void LISTA_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            amicone tmp = LISTA_1.SelectedItem as amicone;
            bool ispossible = true;
            for (int i = 0; i < LISTA_2.Items.Count; i++)
            {
                if (tmp == LISTA_2.Items[i])
                    ispossible = false;
            }
            if (ispossible)
            {
                LISTA_2.Items.Add(tmp);
            }
        }

        private void BTT_GENERAINVITI_Click(object sender, RoutedEventArgs e)
        {
            if(LISTA_2.Items.Count > 0)
            {
                for (int i = 0; i < LISTA_2.Items.Count; i++)
                {
                    StreamWriter sw =  new StreamWriter(LISTA_2.Items[i].ToString());
                    sw.WriteLine("CIAO"+ LISTA_2.Items[i].ToString() + " !");
                    sw.WriteLine("ti va di venire alla festa che sto organizzando il giorno " + DateTime.Now.ToShortDateString() + " alle ore " + DateTime.Now.ToShortTimeString());
                    sw.WriteLine("si svolgera qua: ");
                    sw.WriteLine("MONDO DI PIPPI CALZELUNGHE");
                    sw.WriteLine("ecco il link di maps per arrivarci:\r\n");
                    sw.WriteLine("https://www.google.com/maps?q=<<Latitudine>>,<<Longitudine>>;");
                    sw.Close();
                    sw.Dispose();
                }
            }
        }
    }
}
