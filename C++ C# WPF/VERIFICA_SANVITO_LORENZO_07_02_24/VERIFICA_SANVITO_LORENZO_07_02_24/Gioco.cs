using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICA_SANVITO_LORENZO_07_02_24
{
    public class Gioco //:INotifyPropertyChanged
    {

        //public event PropertyChangedEventHandler PropertyChanged;//mi serve se uso la tabella

        //PROPRIETA'
        public string Nome {  get; set; }
        public string Descrizione { get; set;}
        public float prezzo { get; set;}
        public string DataUscita { get; set;}
        public string Genere { get; set;}

        //COSTRUTTORE PARAMETRICO
        public Gioco(string nome, string descrizione, float prezzo, string dataUscita, string genere)
        {
            Nome = nome;
            Descrizione = descrizione;
            this.prezzo = prezzo;
            DataUscita = dataUscita;
            Genere = genere;
        }

        //TOCSV
        public string toCSV()
        {
            return Nome.Replace(";", " ") + ";" + Descrizione.Replace(";", " ") + ";" + prezzo.ToString().Replace(".", ",").Replace(";", " ") + ";" + DataUscita.Replace(";", " ") + ";" + Genere.Replace(";", " ") + ";";
        }

        //VISUALIZZA
        public string visualizza()
        {
            return "NOME: " + Nome.Replace(";", " ") + "\r\n" +
                "DESCRIZIONE: " + Descrizione.Replace(";", " ") + "\r\n" +
                "PREZZO: " + prezzo.ToString().Replace(".", ",").Replace(";", " ") + "\r\n" +
                "DATA USCITA: " + DataUscita.Replace(";", " ") + "\r\n" +
                "GENERE: " + Genere.Replace(";", " ") + "\r\n";
        }

        //PARSE
        public  static Gioco parse(string s)
        {
            string[] tmp = s.Split(';');
            Gioco g = new Gioco(tmp[0], tmp[1], float.Parse(tmp[2]), tmp[3], tmp[4]);
            return g;
        }

        //OVERRIDE DEL TOSTRING
        public override string ToString()
        {
            return Nome + " " + prezzo.ToString();
        }
    }
}
