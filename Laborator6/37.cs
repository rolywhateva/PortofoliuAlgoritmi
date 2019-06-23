using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laborator6
{
    class _37
    {
        static int n, m, lg1 = 0, lg2 = 0, lg = 0;
        static bool ter1, ter2;
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../date.in");
            string[] dim = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(dim[0]);
            m = int.Parse(dim[1]);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
                    a[i, j] = int.Parse(tokens[j]);
            }
            Utils.PrintMatrix(a);

            bool[,] b = new bool[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!b[i, j] && a[i, j] == 0)
                    {
                        lg = 0;
                        ter1 = ter2 = false;

                        PA(a, b, i, j);
                        if(ter1^ter2)
                        {
                            if (ter1 == true)
                                lg1 += lg;
                            if (ter2 == true)
                                lg2 += lg;
                        }
                    }
            Console.WriteLine("Teritoriu de 1 : " + lg1);
            Console.WriteLine("Teritoriu de 2 : " + lg2);

            return;
        }

        private static void PA(int[,] a, bool[,] b, int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j])
            {

                if (a[i, j] == 1)
                    ter1 = true;
                else
                     if (a[i, j] == 2)
                    ter2 = true;
                else
                {
                    lg++;
                    b[i, j] = true;
                    PA(a, b, i + 1, j);
                    PA(a, b, i, j + 1);
                    PA(a, b, i - 1, j);
                    PA(a, b, i, j - 1);
                }




            }
        }
    }
}
