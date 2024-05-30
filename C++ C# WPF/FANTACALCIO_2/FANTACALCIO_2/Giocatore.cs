using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FANTACALCIO_2
{
    public class 
        Giocatore : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //PROPRIETA'
        public string Nome {  get; set; }
        public string ruolo {  get; set; }
        public int numeroMaglia {  get; set; }

        //COSTRUTTORE
        public Giocatore(string nome, string ruolo, int numeroMaglia)
        {
            Nome = nome;
            this.ruolo = ruolo;
            this.numeroMaglia = numeroMaglia;
        }

        public string toCSV()
        {
            return Nome.Replace(";", " ") + ";" + ruolo.Replace(";"," ") + ";" + numeroMaglia + "\r\n";
        }

        public static Giocatore parse(string s)
        {
            string[] campi = s.Split(';');
            Giocatore tmp = new Giocatore(campi[0], campi[1], int.Parse(campi[2]));
            return tmp;
        }
        public override string ToString()
        {
            return Nome + " " + ruolo + " " + numeroMaglia;
        }
    }
}
