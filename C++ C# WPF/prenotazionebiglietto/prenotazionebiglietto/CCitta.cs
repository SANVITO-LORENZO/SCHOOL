using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prenotazionebiglietto
{


    internal class CCitta
    {    
        private string nome = "";
        private int prezzo = 0;

        public CCitta(string nome)
        {
            this.nome = nome;
            this.prezzo = 0;
        }

        public string getNome() { 
            return nome;
        }
        public int getPrezzo() { 
            return prezzo;
        }
        public void setNome(string nome)
        {
            this.nome=nome;
        }
        public void setPrezzo(int prezzo)
        {
            this.prezzo= prezzo;
        }

        public int calcolaPrezzo( )
        {
            if (nome == "COMO")
                prezzo += 10;
            if (nome == "MILANO")
                prezzo += 20;
            if (nome == "TORINO")
                prezzo += 40;
            if (nome == "ROMA")
                prezzo += 60;
            return prezzo;
        }

    }
}
