using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul14
{
    class Coada
    {
        public int n;
        public Data[] v;
        public Coada()
        {
            n = 0;
            v = new Data[n];

        }
        public void Add(Data add)
        {
            n++;
            Data[] t = new Data[n];
            for (int i = 0; i < n-1; i++)
                t[i+1] = v[i];
            t[0] = add;
            v = t;
        }
        public Data  Remove()
        {
            Data toRemove = v[n - 1];
            n--;
            Data[] t = new Data[n];

            for (int i = 0; i < n; i++)
                t[i] = v[i];
            v = t;
            return toRemove;
        }
        public void View()
        {
            for (int i = 0; i < n; i++)
                Console.Write(v[i]+"\t");
        }
    }
}
