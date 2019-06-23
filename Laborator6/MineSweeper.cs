using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator6
{
    class MineSweeper
    {

        static int n = 15;
        static int m = 15;
        static string[,] a;
        static bool[,] b;
        static int bombCount;
        static int[] dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
        static int[] dy = { -1, 0, 1, 1, 1, 0, -1, -1 };
        /**
         *    ? - spatiu nedescoperit
         *    B - bomba
         *    
         * 
         * 
         * */
        static string[,] RandomMatrix()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string[,] toReturn = new string[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    int seed = rnd.Next(35);
                    if (seed <5)
                    {
                        toReturn[i, j] = "B";
                        bombCount++;
                    }
                    else
                        toReturn[i, j] = "?";
                }
            return toReturn;

        }
        static void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                  //  if (b[i, j])
                        Console.Write("{0,3}", a[i, j]);
                //    else
                    //    Console.Write("{0,3}", "?");
                Console.WriteLine();
            }
        }
        static int Bombs(int i, int j)
        {
            int nr = 0;
            for (int z = 0; z < dx.Length; z++)
            {
                if (i + dx[z] >= 0 && j + dy[z] >= 0 && i + dx[z] < n && j + dy[z] < m && a[i + dx[z], j + dy[z]] == "B")
                    nr++;

            }
            return nr;
        }
        static void SetBombCount()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] != "B")
                        a[i, j] = Bombs(i, j).ToString();

        }
        public static void Main()
        {
            b = new bool[n, m];
            a = RandomMatrix();
            Console.WriteLine(bombCount);
            SetBombCount();
            PrintMatrix();








            return;
        }
    }
}
