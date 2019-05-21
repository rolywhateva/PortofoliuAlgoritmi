using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class secventa
    {
        static void Main()
        {
            int a;
            int min = int.MaxValue;
            int nrmin = 0;
            int iteratii = 0;
            Console.WriteLine("Dati numar:");
            a = int.Parse(Console.ReadLine());
            while (a != -1)
            {
                if (a < min)
                {
                    min = a;
                    nrmin = 1;
                }
                else
                      if (a == min)
                    nrmin++;
                iteratii++;
                Console.WriteLine("Dati numar:");
                a = int.Parse(Console.ReadLine());

            }

            if (iteratii == 0)
                Console.WriteLine("Minimul este -1");
            else
                Console.WriteLine("Valoarea minima :{0}\n Numarul de aparitii : {1}",
                                   min, nrmin);
            Console.ReadKey();

            return;
        }
    }
}
