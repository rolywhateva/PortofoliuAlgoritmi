using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class fibbonaci
    {
        static void fibo(int n,int contor,int a, int b)
        {
            if (contor > n)
                return;
            else
            {
                Console.Write((a + b) + "\t");
                fibo(n, contor + 1, b, a + b);
      
            }
        }
        static void Main()
        {
            fibo(10, 1, 1,0);
            return;
        }
    }
}
