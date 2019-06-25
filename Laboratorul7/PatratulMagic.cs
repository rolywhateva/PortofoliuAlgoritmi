using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul7
{
    class PatratulMagic
    {
        public static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        private static bool esteSolutie(int[] sol)
        {
            int sl1 = sol[0] + sol[1] + sol[2];
            int sl2 = sol[3] + sol[4] + sol[5];
            int sl3 = sol[6] + sol[7] + sol[8];
            int sc1 = sol[0] + sol[3] + sol[6];
            int sc2 = sol[1] + sol[4] + sol[7];
            int sc3 = sol[2] + sol[5] + sol[8];
            int sd1 = sol[0] + sol[4] + sol[8];
            int sd2 = sol[6] + sol[4] + sol[2];
            return (sl1 == sl2 && sl2 == sl3
                    && sc1 == sc2 && sc2 == sc3
                    && sd1 == sd2);
        }
        public static void Main()
        {
            int n = 9;
            int[] a = new int[n];
            int ct = 0;
            for (int i = 0; i < n; i++)

                a[i] = ++ct;
            int limita = int.MaxValue - 10;
            Random rnd = new Random();
            int k = 0;
            do
            {
                int l1, l2;
                do
                {
                 
                    l1 = rnd.Next() % n;
                    l2 = rnd.Next() % n;

                    Swap(ref a[l1], ref a[l2]);
                    k++;
                    if (k > limita) break;

                } while (!esteSolutie(a));
                if (k > limita) break;

                if(k<limita)
                for (int i = 0; i < n; i++)
                {

                    Console.Write(a[i] + "\t");
                    if ((i + 1) % 3 == 0)
                        Console.WriteLine();
                }
                Console.WriteLine("============================");
                Console.ReadKey();
               /*
                l1 = rnd.Next() % n;
                l2 = rnd.Next() % n;

                Swap(ref a[l1], ref a[l2]);
                k++;
                */


            } while (k <= limita);

            Console.WriteLine(k);
            Console.WriteLine();


        }
    }
}
