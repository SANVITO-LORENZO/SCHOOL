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

namespace VERIFICA_SANVITO_LORENZO_07_02_24
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //LISTE 
        ObservableCollection<Gioco>listagiochi = new ObservableCollection<Gioco>();
        ObservableCollection<Gioco> listacarrello = new ObservableCollection<Gioco>();
        ObservableCollection<string> listageneri = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            lista_giochi.ItemsSource = listagiochi;
            COMBO_GENERE.ItemsSource = listageneri;

            StreamReader sr = new StreamReader("giochi.txt");
            while (!sr.EndOfStream)
            {
                string tmp = sr.ReadLine();
                listagiochi.Add(Gioco.parse(tmp));
            }
            sr.Close();
            sr.Dispose();

            StreamReader sr2 = new StreamReader("generi.txt");
            while (!sr2.EndOfStream)
            {
                string tmp = sr2.ReadLine();
                listageneri.Add(tmp);
            }
            sr2.Close();
            sr2.Dispose();

            COMBO_GENERE.SelectedIndex = 0;

        }

        private void BTT_INSERISCI_Click(object sender, RoutedEventArgs e)
        {
            if (TXT_DESCRIZIONE.Text != string.Empty && TXT_NOME.Text != string.Empty && TXT_PREZZO.Text != string.Empty && DATA_PICKER.Text != string.Empty) 
            {
                Gioco tmp = new Gioco(TXT_NOME.Text, TXT_DESCRIZIONE.Text, float.Parse(TXT_PREZZO.Text.Replace(".",",")), DATA_PICKER.Text, COMBO_GENERE.Text);
                listagiochi.Add(tmp);

                MessageBox.Show("gioco inserico correttamente");

                StreamWriter sw = new StreamWriter("giochi.txt", true);
                sw.WriteLine(tmp.toCSV());
                sw.Close();
                sw.Dispose();

                TXT_PREZZO.Text = string.Empty;
                TXT_NOME.Text = string.Empty;
                TXT_DESCRIZIONE.Text = string.Empty;
                COMBO_GENERE.SelectedIndex = 0;
                DATA_PICKER.Text = string.Empty;
            }
            else
                MessageBox.Show("controllare che tutti i dati inseriti siano corretti / riempire tutti i parametri richiesti");
        }

        private void BTT_VISUALIZZA_Click(object sender, RoutedEventArgs e)
        {
            if (lista_giochi.SelectedItem != null)
            {
                Gioco tmp = lista_giochi.SelectedItem as Gioco;
                MessageBox.Show(tmp.visualizza());
                lista_giochi.SelectedItem = null;
            }
            else
                MessageBox.Show("seleziona un elemento dalla lista prima di procedere");
            
        }

        private void BTT_RIMUOVI_Click(object sender, RoutedEventArgs e)
        {
            if (lista_giochi.SelectedItem != null)
            {
                MessageBox.Show("gioco rimosso");
                listagiochi.Remove(lista_giochi.SelectedItem as Gioco);

                StreamWriter sw = new StreamWriter("giochi.txt");
                for(int x = 0;x < listagiochi.Count; x++)
                {
                    sw.WriteLine(listagiochi[x].toCSV());
                }
                sw.Close();
                sw.Dispose();
            }
            else
                MessageBox.Show("seleziona un elemento dalla lista prima di procedere");
        }

        private void BTT_INSERISCI_Copia_Click(object sender, RoutedEventArgs e)
        {
            if (lista_giochi.SelectedItem != null)
            {
                listacarrello.Add(lista_giochi.SelectedItem as Gioco);
                MessageBox.Show("gioco inserito al carrello");
            }
            else
                MessageBox.Show("seleziona un elemento dalla lista prima di procedere");
        }

        private void BTT_CARRELLO_Click(object sender, RoutedEventArgs e)
        {
            Carrello tmp = new Carrello(listacarrello);
            tmp.ShowDialog();
        }
    }
}
