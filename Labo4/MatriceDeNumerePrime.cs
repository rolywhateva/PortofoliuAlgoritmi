using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    class MatriceDeNumerePrime
    {
     static bool prim(int n)
        {
            if (n < 2)
                return false;
            if (n % 2 == 0 && n != 2)
                return false;
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0)
                    return false;
            return true;
                     
                
        }
       static  int[,]  prime(int n, int m)
        {
            int[,] a = new int[n, m];
            int c = 1;
            for(int i=0;i<n;i++)
                 for(int j=0;j<m;j++)
                {
                    bool estePrim;
                    do
                    {
                        c++;
                        estePrim = prim(c);
                    } while (!estePrim);
                    a[i, j] = c;

                }
            return a;
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            int[,] a = prime(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
