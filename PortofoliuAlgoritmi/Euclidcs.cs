using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class Euclidcs
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Dati primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati al doilea numar:");
            b = int.Parse(Console.ReadLine());

            int r = a % b;
            while(r!=0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Console.WriteLine("Cmmdc : {0}", b);


            return;
        }
    }
}
