using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class Palindrom
    {
        static void Main()
        {
            int nr;
            Console.WriteLine("Dati un numar :");
            nr = int.Parse(Console.ReadLine());
            int nou = 0;
            int aux = nr;
            while(nr!=0)
            {
                nou = nou * 10 + nr % 10;
                nr = nr / 10;
            }
            if (nou == aux)
                Console.WriteLine("Palindrom");
            else
                Console.WriteLine("Nu este palindrom");
            Console.ReadKey();
            return;
        }
    }
}
