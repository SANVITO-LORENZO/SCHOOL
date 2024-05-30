using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voti
{
    internal class calcoli
    {
        List<float> list = new List<float>();
        int numel = 0;

        public void add_voto(float voto)
        {
            list.Add(voto);
            numel++;
        }

        public float get_numel()
        {
            return numel;
        }

        public float get_media()
        {
            float m = 0;
            for (int i = 0; i < list.Count; i++)
            {
                m+= list[i];
            }
            return m/=list.Count;
        }
    }
}
