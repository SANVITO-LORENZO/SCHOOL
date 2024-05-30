using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class testo
    {
        string tmp = "";
        public void aggiungi_testo(string t)
        {
            tmp += t ;
            tmp += "\t\n";
        }

        public string ritorna_testo()
        {
            return tmp;
        }
    }
}
