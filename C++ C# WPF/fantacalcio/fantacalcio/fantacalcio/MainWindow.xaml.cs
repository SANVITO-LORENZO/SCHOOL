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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fantacalcio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Calciatore> squadra;
        public MainWindow()
        {
            squadra=new List<Calciatore>();
            InitializeComponent();
        }

        private void bottoneNomeFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(testoPath.Text);
            if (!File.Exists(testoPath.Text))
            {
                MessageBox.Show("File non esistente!!RIPROVA!!");
            }
            else
            {
                try
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Dividi la riga utilizzando il punto e virgola come separatore
                        string[] parts = line.Split(';');

                        // Assegna a nome, ruolo e numeroMaglia le parti corrispondenti
                        string nome = parts[0].Trim();
                        string ruolo = parts[1].Trim();
                        string numeroMaglia = parts[2].Trim();

                        // Crea un nuovo oggetto Giocatore e aggiungilo alla lista
                        Calciatore giocatore = new Calciatore(nome, ruolo, numeroMaglia);
                        squadra.Add(giocatore);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la lettura del file: {ex.Message}");
                }
                form2 form2 = new form2(squadra);
                form2.ShowDialog();
            }
        }
    }
}
