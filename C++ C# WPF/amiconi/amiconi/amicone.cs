using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiconi
{
    public class amicone : INotifyCollectionChanged
    {

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public string mail { get; set; }
        public int numero { get; set; }

        public amicone(string nome, string cognome, string mail, int numero)
        {
            Nome = nome;
            Cognome = cognome;
            this.mail = mail;
            this.numero = numero;
        }

        public string toCSV()
        {
            return Nome.Replace(";", " ") + ";" + Cognome.Replace(";", " ") + ";"  + "\r\n";
        }

        public static amicone parse(string s)
        {
            string[] campi = s.Split(';');
            amicone tmp = new amicone(campi[0], campi[1], campi[2],int.Parse(campi[3]));
            return tmp;
        }

        public override string ToString()
        {
            return Nome + " "+ Cognome;
        }

        public string getmail()
        {
            return mail;
        }
    }
}
