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

        public int calcola_fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return calcola_fibonacci(num - 1) + calcola_fibonacci(num - 2);
            }
        }
    }
}
