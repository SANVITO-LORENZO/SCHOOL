using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fattoriale
{
    internal class calcoli
    {
        public int calcola_fattoriale(int num)
        {
            if (num == 0|| num ==1 ) 
                return 1;
            else
                return num*calcola_fattoriale(num-1);
        }
    }
}
