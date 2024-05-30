using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace filebinario
{
    internal class Auto
    {
        public Auto(string targa, string descrizione, int km, int prezzo)
        {
            Targa = targa;
            Descrizione = descrizione;
            Km = km;
            Prezzo = prezzo;
        }

        public string Targa { get; set; }
        public string Descrizione { get; set; }
        public int Km { get; set; }
        public int Prezzo { get; set; }

        public override string ToString()
        {
            return Descrizione;
        }
    }
}
