using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPITOINFO
{
    public class giocatore
    {
        //ATTRIBUTI
        private string nome; //nome del giocatore
        private int punti;   //punti da lui segnati
        private int numero;  //numero del giocatore

        //metodi set e get
        public string Nome { get => nome; set => nome = value; }
        public int Punti { get => punti; set => punti = value; }
        public int Numero { get => numero; set => numero = value; }

        //costruttore parametrico
        public giocatore(string nome, int numero)
        {
            this.Nome = nome;
            this.Punti = 0;
            this.Numero = numero;
        }

        public override string ToString()
        {
            return numero.ToString()+ " - " + nome;
        }

    }
}
