using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    class ConstruireMatrici
    {
        static int[,] tip1(int n)
        {
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == n / 2  || j == n / 2)
                        a[i, j] = 0;
                    else
                         if (i < n / 2 )
                    {
                        if (j < n / 2 )
                            a[i, j] = 1;
                        else
                            a[i, j] = 2;
                    }else
                    {
                        if (j < n / 2)
                            a[i, j] = 3;
                        else
                            a[i, j] = 4;
                    }

                      

            return a;
        }

        static int[,] tip2(int n)
        {
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j || i + j == n - 1)
                        a[i, j] = 0;
                    else
                         if (i < j && i + j < n - 1)
                        a[i, j] = 1;
                    else
                         if (i < j && i + j > n - 1)
                        a[i, j] = 2;
                    else
                           if (i > j && i + j > n - 1)
                        a[i, j] = 3;
                    else
                          if (i > j && i + j < n - 1)
                        a[i, j] = 4;



            return a;
        }
        static void Afisare(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[,] a = tip2(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
