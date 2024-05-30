using System;
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
using System.Windows.Shapes;

namespace COMPITOINFO
{
    /// <summary>
    /// Logica di interazione per creazione_squadra.xaml
    /// </summary>
    public partial class creazione_squadra : Window
    {
        //ATTRIBUTI
        private List<giocatore> titolari = new List<giocatore>(); //lista di titolari
        private List<giocatore> panchina = new List<giocatore>(); //lista di panchinari
        int tmp = 1;                                              //variabile che permette di capire dove un giocatore verrà inserito

        //metodi set e get
        public List<giocatore> Titolari { get => titolari; set => titolari = value; }
        public List<giocatore> Panchina { get => panchina; set => panchina = value; }
        public int Tmp { get => tmp; set => tmp = value; }

        public creazione_squadra()
        {
            InitializeComponent();
        }

        //pulsante aggiungi
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //controllo se ho raggiunto il numero massimo di giocatori sennò aggiungo
            if (tmp < 23)
            {
                //se la text box è piena procedo
                if (txt_giocatore.Text != string.Empty)
                {
                    //se minore di 16 aggiungo a titolari senno a panchina
                    if (tmp < 16)
                    {
                        lista_titolari.Items.Add(new giocatore(txt_giocatore.Text, tmp));
                        titolari.Add(new giocatore(txt_giocatore.Text, tmp));
                    }
                    else
                    {
                        lista_panchinari.Items.Add(new giocatore(txt_giocatore.Text, tmp));
                        panchina.Add(new giocatore(txt_giocatore.Text, tmp));
                    }
                    tmp++;
                    //pulisco la text box
                    txt_giocatore.Text = string.Empty;
                }
                else
                    MessageBox.Show("INSERIRE ALMENO UN CARATTERE NELLA TEXT BOX");
            }
            else { 
                //mostro finestra di errore e disabilito il bottone aggiungi
                MessageBox.Show("HAI RAGGIUNTO IL NUMERO MASSIMO DI GIOCATORI");
                btt_aggiungi.IsEnabled= false;
            }
        }

        //pulsante continua
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //questo controllo perchè per giocare ci vorrebbero un minimo di 15 giocatori
            if (tmp > 15)
                this.Close();
            else
                MessageBox.Show("NUMERO DI GIOCATORI INSUFFICENTE PER PROCEDERE");
        }
    }
}
