using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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

namespace fantacalcio
{
    /// <summary>
    /// Logica di interazione per form2.xaml
    /// </summary>
    public partial class form2 : Window
    {
        List<Calciatore> rosa;
        List<Calciatore> titolari;
        public form2(List<Calciatore> squadra)
        {
            InitializeComponent();
            this.rosa = squadra;
            for (int i = 0; i < squadra.Count; i++)
            {
                listBoxNomi.Items.Add(squadra[i]);
                listBoxNomi.Items[i] = squadra[i].nome;
            }
            titolari = new List<Calciatore>();
        }

        private void listBoxNomi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = listBoxNomi.SelectedIndex;
            if (indice != -1)
            {
                testoNome.Text = rosa[indice].nome;
                testoNumero.Text = rosa[indice].numeroMaglia.ToString();
                testoRuolo.Text = rosa[indice].ruolo;
            }
        }

        private void bottoneAggiungi_Click(object sender, RoutedEventArgs e)
        {
            int indice = listBoxNomi.SelectedIndex;
            if (titolari.Contains(rosa[indice]))
            {
                MessageBox.Show("Non puoi inserire lo stesso giocatore due volte!!");
            }
            else
            {
                if (titolari.Count >= 11)
                {
                    MessageBox.Show("Hai finito i titolari!!");
                }
                else
                {
                    titolari.Add(rosa[indice]);
                    listaTitolari.Items.Add(rosa[indice].nome);
                }
            }
        }

        private void bottoneRimuovi_Click(object sender, RoutedEventArgs e)
        {
            int indice = listaTitolari.SelectedIndex;
            if (indice != -1) // se è stato selezionato un elemento
            {
                titolari.RemoveAt(indice);
                listaTitolari.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Seleziona un giocatore da rimuovere!!");
            }
        }

        private void listaTitolari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void bottoneFile_Click(object sender, RoutedEventArgs e)
        {
            string s = "GIOCATORI ROSA:\n";

            for (int i = 0; i < rosa.Count; i++)
            {
                s += rosa[i].nome+"\n";
            }

            s += "GIOCATORI TITOLARI:\n";

            for (int i = 0; i < titolari.Count; i++)
            {
                s += titolari[i].nome + "\n";
            }
            DateTime oggi= DateTime.Now;
            string data=oggi.ToString();
            data = data.Replace("/", "");
            data = data.Replace(":", "");
            StreamWriter streamWriter = new StreamWriter("formazione"+data+".txt");
            streamWriter.WriteLine(s);
            streamWriter.Close();
        }
    }
}
