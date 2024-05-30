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
using System.Timers;
using System.IO;

namespace COMPITOINFO
{
    /// <summary>
    /// Logica di interazione per statistiche.xaml
    /// </summary>
    public partial class statistiche : Window
    {
        //ATTRIBUTI
        Timer timer;                                              //timer
        private List<giocatore> titolari = new List<giocatore>(); //lista di titolari
        private List<giocatore> panchina = new List<giocatore>(); //lista di panchinari
        int tempo = 0;                                            //tempo della partita

        giocatore tmp1;     //variabile usata per salvare temporaneamente un giocatore
        giocatore tmp2;     //variabile usata per salvare temporaneamente un giocatore

        int punteggio_casa = 0;
        int punteggio_ospiti = 0;

        //metodi set e get
        public List<giocatore> Titolari { get => titolari; set => titolari = value; }
        public List<giocatore> Panchina { get => panchina; set => panchina = value; }

        public statistiche()
        {
            //creo un timer che reinizia ogni minuto
            timer = new Timer(60000);
            // Collega il metodo "IncrementaTmp" al timer
            timer.Elapsed += new ElapsedEventHandler(IncrementaTmp);
            InitializeComponent();

        }

        //funzione chiamata da public statistiche()
        private void IncrementaTmp(object source, ElapsedEventArgs e)
        {
              //faccio questa funzione perchè il timer e this usano la stessa variabile tempo
              this.Dispatcher.Invoke((Action)delegate
              {
                  tempo += 1; 
                    txt_tempo.Text = "MINUTI TRASCORSI: " + tempo.ToString();
              });
        }
        private void btt_inizia_Click(object sender, RoutedEventArgs e)
        {
            //scrivo senno non si visualizzerà niente
            txt_tempo.Text = "MINUTI TRASCORSI: 0";
            //inizia il timer
            timer.Start(); 
            //il button inizia viene disabilitato
            btt_inizia.IsEnabled = false;
            //abilito tutto
            btt_CPU_casa.IsEnabled = true;
            btt_CPU_avversari.IsEnabled = true;
            btt_CP_avversari.IsEnabled = true;
            btt_CP_casa.IsEnabled = true;
            btt_giallo.IsEnabled = true;
            btt_rosso.IsEnabled = true;
            btt_punizione.IsEnabled = true;
            btt_meta_avv.IsEnabled = true;
            btt_meta.IsEnabled = true;
            btt_termina.IsEnabled = true;
            btt_sostitisci.IsEnabled = true;
            lista_panchinarii.IsEnabled = true;
            lista_titolarii.IsEnabled = true;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tmp1 != null && tmp2 != null)
            {
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine(tmp1.ToString() + " SOSTITUITO CON " + tmp2.ToString());
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
                //rimuovo il giocatore selezionato e ne aggiungo un altro
                panchina.Remove(tmp2);
                panchina.Add(tmp1);
                //rimuovo il giocatore selezionato e ne aggiungo un altro
                titolari.Remove(tmp1);
                titolari.Add(tmp2);
                //rimuovo tutti gli elementi delle due liste
                lista_titolarii.Items.Clear();
                lista_panchinarii.Items.Clear();
                //aggiungo gli elementi alla listbox prendendoli dalla lista titolari
                for (int i = 0; i < titolari.Count; i++)
                {
                    lista_titolarii.Items.Add(titolari[i]);
                }
                //aggiungo gli elementi alla listbox prendendoli dalla lista panchinari
                for (int x = 0; x < panchina.Count; x++)
                {
                    lista_panchinarii.Items.Add(panchina[x]);
                }
                //imposto le due variabile dei giocatori selezionati a null
                tmp1 = null; tmp2 = null;
            }
            else
                MessageBox.Show("PERFAVORE SELEZIONARE ALMENO UN GIOCATORE DA OGNI LISTBOX");
        }

        private void btt_meta_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 != null)
            {
                //aumento il punteggio
                punteggio_casa += 5;
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine("META SEGNATA DA " + tmp1.ToString());
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
                //metto a nulla la variabile del giocatore selezionato
                tmp1 = null;
            }
            else
                MessageBox.Show("SELEZIONARE IL GIOCATORE CHE HA SEGNATO LA META DALLA LISTA DEI TITOLARI");
        }

        private void btt_CP_casa_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 != null)
            {
                //aumento il punteggio
                punteggio_casa += 2;
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine("CALCIO PIAZZATO SEGNATA DA " + tmp1.ToString());
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
                //metto a nulla la variabile del giocatore selezionato
                tmp1 = null;
            }
            else
                MessageBox.Show("SELEZIONARE IL GIOCATORE CHE HA SEGNATO IL CALCIO PIAZZATO DALLA LISTA DEI TITOLARI");
        }

        private void btt_CPU_casa_Click(object sender, RoutedEventArgs e)
        {
            
           if (tmp1 != null)
           {
                //aumento il punteggio
                punteggio_casa += 3;
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine("CALCIO DI PUNIZIONE SEGNATA DA " + tmp1.ToString());
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
                //metto a nulla la variabile del giocatore selezionato
                tmp1 = null;
           }
           else
                MessageBox.Show("SELEZIONARE IL GIOCATORE CHE HA SEGNATO IL CALCIO PIAZZATO DA UNA PUNIZIONE/FASE DI GIOCO DALLA LISTA DEI TITOLARI");

        }

        private void btt_meta_avv_Click(object sender, RoutedEventArgs e)
        {
            punteggio_ospiti += 5;
            //scrivo sul file di testo
            try
            {
                StreamWriter sw = new StreamWriter("statistiche.txt", true);
                sw.WriteLine("");
                sw.WriteLine("MINUTO " + tempo);
                sw.WriteLine("META AVVERSARIA");
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
        }
        private void btt_CP_avversari_Click(object sender, RoutedEventArgs e)
        {
            punteggio_ospiti += 2;
            //scrivo sul file di testo
            try
            {
                StreamWriter sw = new StreamWriter("statistiche.txt", true);
                sw.WriteLine("");
                sw.WriteLine("MINUTO " + tempo);
                sw.WriteLine("CALCIO PIAZZATO AVVERSARIO");
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
        }

        private void btt_CPU_avversari_Click(object sender, RoutedEventArgs e)
        {
            punteggio_ospiti += 3;
            //scrivo sul file di testo
            try
            {
                StreamWriter sw = new StreamWriter("statistiche.txt", true);
                sw.WriteLine("");
                sw.WriteLine("MINUTO " + tempo);
                sw.WriteLine("CALCIO DI PUNIZIONE AVVERSARIO");
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
        }

        private void btt_punizione_Click(object sender, RoutedEventArgs e)
        {
            //scrivo sul file di testo
            try
            {
                StreamWriter sw = new StreamWriter("statistiche.txt", true);
                sw.WriteLine("");
                sw.WriteLine("MINUTO " + tempo);
                sw.WriteLine("PUNIZIONE CONTRO");
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
        }

        private void btt_giallo_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 != null)
            {
                //aumento il punteggio
                punteggio_casa += 3;
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine("CARTELLINO GIALLO PRESO DA " + tmp1.ToString());
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
                //metto a nulla la variabile del giocatore selezionato
                tmp1 = null;
            }
            else
                MessageBox.Show("SELEZIONARE IL GIOCATORE CHE HA PRESO IL CARTELLINO DALLA LISTA DEI TITOLARI");

        }

        private void btt_rosso_Click(object sender, RoutedEventArgs e)
        {
            if (tmp1 != null)
            {
                //scrivo sul file di testo
                try
                {
                    StreamWriter sw = new StreamWriter("statistiche.txt", true);
                    sw.WriteLine("");
                    sw.WriteLine("MINUTO " + tempo);
                    sw.WriteLine("CARTELLINO ROSSO PRESO DA " + tmp1.ToString());
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
                //metto a nulla la variabile del giocatore selezionato
                tmp1 = null;
            }
            else
                MessageBox.Show("SELEZIONARE IL GIOCATORE CHE HA PRESO IL CARTELLINO DALLA LISTA DEI TITOLARI");

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //scrivo sul file di testo
            try
            {
                StreamWriter sw = new StreamWriter("statistiche.txt", true);
                sw.WriteLine("");
                sw.WriteLine("PARTITA CONCLUSA");
                sw.WriteLine("CASA: " + punteggio_casa.ToString() + " OSPITI: " + punteggio_ospiti.ToString());
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
            //la finesta viene chiusa
            this.Close();
        }

        private void lista_titolarii_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //aseggnato il giocatore selezionato alla variabile temporanea
            tmp1=(giocatore)lista_titolarii.SelectedItem;
        }

        private void lista_panchinarii_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //aseggnato il giocatore selezionato alla variabile temporanea
            tmp2 =(giocatore)lista_panchinarii.SelectedItem;
        }


    }
}
