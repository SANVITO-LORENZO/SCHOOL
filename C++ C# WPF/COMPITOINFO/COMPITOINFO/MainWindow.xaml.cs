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
using System.IO.Ports;

namespace COMPITOINFO
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //VARIABILE
        private string squadra_casa, squadra_ospite;                //nomi delle due squadre che si scontreranno
        private string data_partita;                                //data in cui la partita sarà svolta
        private int tmp = 0;                                        //variabile che permette al programma di decidere quale finestra aprire
        private bool scelta = false;                                //variabile che permette di capire che squadra ha selezionato l'utente
        private List<giocatore> titolari = new List<giocatore>();   //lista di titolari
        private List<giocatore> panchina = new List<giocatore>();   //lista di panchinari

        //metodi set e get 
        public string Squadra_casa { get => squadra_casa; set => squadra_casa = value; }
        public string Squadra_ospite { get => squadra_ospite; set => squadra_ospite = value; }
        public string Data_partita { get => data_partita; set => data_partita = value; }
        public int Tmp { get => tmp; set => tmp = value; }
        public bool Scelta { get => scelta; set => scelta = value; }

        public MainWindow()
        {
            InitializeComponent();
            dataTimePicker.Text = DateTime.Now.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //controllo che le due textbox contengano almeno un carattere
            if (txb_casa.Text != string.Empty && txt_ospite.Text != string.Empty)
            {

                //se tmp sarà uguale a 0
                if (tmp == 0)
                {

                    //le textbox e il datatimepicker della prima finestra vengono bloccate
                    txt_ospite.IsEnabled = false;
                    txb_casa.IsEnabled = false;
                    dataTimePicker.IsEnabled = false;

                    //si apre la finestra scelta squadra
                    scelta_squadra modale = new scelta_squadra();

                    //il testo delle due text box si modifica in base a quello che l'utente ha precedentemente scritto
                    modale.text_box_squadra1.Text = txb_casa.Text;
                    modale.text_box_squadra2.Text = txt_ospite.Text;
                    modale.ShowDialog();

                    //i dati delle textbox e del datatimepicker vengono salvati in delle variabili
                    squadra_casa = txb_casa.Text;
                    squadra_ospite = txt_ospite.Text;
                    data_partita = dataTimePicker.Text;
                    scelta = modale.Scelta;

                    //la variabile tmp aumenta cosi la prossima volta che questo tasto verrà premuto si aprirà una nuova finestra
                    tmp++;

                    //scrivo sul file di testo
                    try { 
                        StreamWriter sw = new StreamWriter("statistiche.txt",true);
                        sw.WriteLine("---------------------------------------------");
                        sw.WriteLine(squadra_casa + " VS " + squadra_ospite);
                        sw.WriteLine("PARTITA DEL " + data_partita);
                        if(scelta==false)
                            sw.WriteLine("SI PRENDONO LE STATISTICHE DELLA SQUADRA DI CASA");
                        if(scelta==true)
                            sw.WriteLine("SI PRENDONO LE STATISTICHE DELLA SQUADRA OSPITE");
                        sw.Close();
                    }
                    catch (Exception w)
                    {
                        Console.WriteLine("Exception: " + w.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
  
                    //in questo modo l'utente dovrà ripremere il tasto continua
                    return;
                }

                if (tmp == 1)
                {
                    //si apre la finestra creazione della squadra
                    creazione_squadra modale = new creazione_squadra();
                    modale.ShowDialog();

                    //i dati delle liste vengono salvati in delle variabili
                    panchina = modale.Panchina;
                    titolari = modale.Titolari;

                    //la variabile tmp aumenta cosi la prossima volta che questo tasto verrà premuto si aprirà una nuova finestra
                    tmp++;

                    //scrivo sul file di testo
                    try
                    {
                        StreamWriter sw = new StreamWriter("statistiche.txt", true);
                        sw.WriteLine("");
                        sw.WriteLine("LISTA TITOLARI:");
                        for (int i = 0; i < titolari.Count; i++)
                        {
                            sw.WriteLine(titolari[i].ToString());
                        }
                        sw.WriteLine("");
                        if (panchina.Count != 0) { 
                            sw.WriteLine("LISTA PANCHINARI:");
                            for (int i = 0; i < panchina.Count; i++)
                            {
                                sw.WriteLine(panchina[i].ToString());
                            }
                        }
                        sw.Close();
                    }
                    catch (Exception w)
                    {
                        Console.WriteLine("Exception: " + w.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }

                    //in questo modo l'utente dovrà ripremere il tasto continua
                    return;
                }

                if (tmp == 2)
                {
                    statistiche modale = new statistiche();

                    //inizializzo le due listbox e aggiungo alle liste i vari giocatori
                    for (int i = 0; i < titolari.Count; i++)
                    {
                        modale.Titolari.Add(titolari[i]);
                        modale.lista_titolarii.Items.Add(titolari[i]);
                    }
                    for (int i = 0; i < panchina.Count; i++)
                    {
                        modale.Panchina.Add(panchina[i]);
                        modale.lista_panchinarii.Items.Add(panchina[i]);
                    }
                    //si apre la finestra statitiche
                    modale.ShowDialog();

                    //la variabile tmp aumenta cosi la prossima volta che questo tasto verrà premuto si aprirà una nuova finestra
                    tmp++;

                    //in questo modo l'utente dovrà ripremere il tasto continua
                    return;

                }
                if(tmp == 3)
                {
                    //chiudo il programma
                    this.Close();
                }
            }
            else
                MessageBox.Show("INSERIRE ENTRAMBI I NOMI DELLE SQUADRE (ALMENO UN CARATTERE)");
        }

    }
}
