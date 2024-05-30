using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCESSIONARIA
{
    internal class auto
    {
        public string modello,motorizzazioni;
        public bool cambio, sensori;

        public auto(string modello, string motorizzazioni, bool cambio, bool sensori)
        {
            this.modello = modello;
            this.motorizzazioni = motorizzazioni;
            this.cambio = cambio;
            this.sensori = sensori;
        }
        public int calcola_prezzo() {
            int prezzo = 0;
            if (modello == "Up")
            {
                if (cambio == true)
                    prezzo += 1500;
                if (sensori == true)
                    prezzo += 800;
                if (motorizzazioni == "Benzina")
                    prezzo += 10000;
                if (motorizzazioni == "Disel")
                    prezzo += 11500;
                if (motorizzazioni == "GPL")
                    prezzo += 11000;
            }
            if(modello == "Golf")
            {
                if (cambio == true)
                    prezzo += 2000;
                if (sensori == true)
                    prezzo += 1000;
                if (motorizzazioni == "Benzina")
                    prezzo += 20000;
                if (motorizzazioni == "Disel")
                    prezzo += 21500;
                if (motorizzazioni == "GPL")
                    prezzo += 21000;
            }
            else
            {
                if (cambio == true)
                    prezzo += 2500;
                if (sensori == true)
                    prezzo += 1200;
                if (motorizzazioni == "Benzina")
                    prezzo += 30000;
                if (motorizzazioni == "Disel")
                    prezzo += 31500;
                if (motorizzazioni == "GPL")
                    prezzo += 31000;
            }
            return prezzo;
        }
    }
}
