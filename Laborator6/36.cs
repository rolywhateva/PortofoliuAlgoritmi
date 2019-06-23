using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator6
{
    class Program
    {
        static int nr = 0;
        static int n = 5;
        static int m = 6;
        static string maxpath = "";
        static string path = "";
        static void PA(int[,] a, bool[,] b, int i, int j, int val)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j] && a[i, j] == val)
            {
                b[i, j] = true;
                nr++;
             
                path += $"({i+1 },{j+1})";
            
                PA(a, b, i + 1, j, val);
                PA(a, b, i, j + 1, val);
                PA(a, b, i - 1, j, val);
                PA(a, b, i, j - 1, val);

            }
        }
        static void Main(string[] args)
        {

            int[,] a = Utils.RandomMatrix(n, m);
            bool[,] b = new bool[n, m];
          
            int nrmax = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!b[i, j])
                    {
                        nr = 0;
                        path = "";
                        PA(a, b, i, j, a[i, j]);
                        if (nrmax < nr)
                        {
                            nrmax = nr;
                            maxpath = path;
                            
                        }


                    }
            Utils.PrintMatrix(a);
            Console.WriteLine("Lungime:" + nrmax);
            Console.WriteLine(maxpath);





        }
    }
}
