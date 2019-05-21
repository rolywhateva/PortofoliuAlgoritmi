using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class CifreleUnuiNumar
    {
        static void Cifre(int n)
        {
            while(n!=0)
            {
                Console.WriteLine(n % 10);
                n = n / 10;
            }
        }
        static void Main()
        {
            Cifre(123);

            Console.ReadKey();
            return;
        }
    }
}
