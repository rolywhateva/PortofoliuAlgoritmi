using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VectorMicInMare
    {
        static int[] GetArray()
        {
            
            Console.WriteLine("Give array:");
            string[]  tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = Array.ConvertAll(tokens, s => int.Parse(s));
            return a;
        }
        static void Main()
        {
            int[] a = GetArray();
            int[] b = GetArray();
            int poz = 0, nr = 0;
            for (int i = 0; i < b.Length; i++)
                if (b[i] == a[poz])
                {
                    poz++;
                    if(poz>=a.Length)
                    {
                        nr++;
                        poz = 0;
                    }
                }
                else
                     if (poz != 0)
                {
                    poz = 0;
                }
            if(nr!=0)
            {
                Console.WriteLine("Da,vectorul a se gaseste in b de {0} ori.", nr);
            }else
            {
                Console.WriteLine("NU");
            }

            Console.ReadKey();
            return;
        }
    }
}
