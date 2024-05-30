using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantacalcio
{
    public class Calciatore
    {       
        public Calciatore(string nome, string ruolo, string numeroMaglia) {
            this.nome = nome;
            this.ruolo = ruolo;
            this.numeroMaglia = numeroMaglia;
        }
        public string nome { get; set; }
        public string numeroMaglia { get; set; }
        public string ruolo { get; set; }
    }
}
