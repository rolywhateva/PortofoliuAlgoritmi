using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul7
{
    class MonteCarlo
    {
        static Random rnd = new Random();
        static string fMonteCarlo(string simbol,int[] ponderi)
        {
            int n = simbol.Length, p = ponderi.Length;
            if (n != p)
                return null;
            int s = 0, i;
            for ( i = 0; i < p; i++)
                s += ponderi[i];

            int val = rnd.Next(0, s);
            int sp = 0;
            for ( i = 0; i < n && sp < val; sp = sp + ponderi[i], i++) ;
            if (i == 0) i = 1;
            return simbol[i - 1].ToString();

        }
        static void Main()
        {
            string simbol = "AB";
            int[] pondere = {1,4 };
            for (int i = 0; i < 100; i++)
            {
                int A = 0, B = 0;
                for (int j = 0; j < 3; j++)
                    if (fMonteCarlo(simbol, pondere) == "A")
                        A++;
                    else
                        B++;
                Console.WriteLine("A={0},B={1}",A,B);
                
            }
        }
    }
}
