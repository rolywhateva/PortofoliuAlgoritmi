using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laborator6
{
    class MineSweeper
    {

        static int n;
        static int m;
        static string[,] a;
        static bool[,] b;
        static int bombCount;
        static int fieldcount;
        static int[] dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
        static int[] dy = { -1, 0, 1, 1, 1, 0, -1, -1 };
        /**
         *    ? - spatiu nedescoperit
         *    B - bomba
         *    
         * 
         * 
         * */
        static void CitireMatrice(out string[,] a, StreamReader sr)
        {
            string[] tokens = sr.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[][] linetokens = new string[tokens.Length][];
            for (int i = 0; i < linetokens.Length; i++)
                linetokens[i] = tokens[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            a = new string[tokens.Length, linetokens[0].Length];
            for (int i = 0; i < linetokens.Length; i++)
                for (int j = 0; j < linetokens[i].Length; j++)
                {
                    a[i, j] = linetokens[i][j];
                    if (a[i, j] == "B")
                        bombCount++;
                    else
                         if (a[i, j] == "0")
                        a[i, j] = "?";
                }




        }
        static string[,] RandomMatrix()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string[,] toReturn = new string[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    int seed = rnd.Next(100);
                    if (seed < 10)
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
        static void ConditionedPrint()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (b[i, j])
                    {
                        if (a[i, j] != "?")

                            Console.Write("{0,3}", a[i, j]);
                        else
                            Console.Write("{0,3}", "_");
                    }
                    else
                        Console.Write("{0,3}", "?");
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
        //Parcurgere in adancime
        public static void PA(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < m 
                && !b[i, j] && a[i, j] != "B")
            {
                b[i, j] = true;
                fieldcount--;
                if (a[i, j] == "?")
                    for (int z = 0; z < dx.Length; z++)
                        PA(i + dx[z], j + dy[z]);

            }
        }

        static public bool Click(int i, int j)
        {

            if (b[i, j] == true)
            {
                Console.WriteLine("Ilegal!");
                return false;
            }
            if (a[i, j] == "B")
                Console.WriteLine("Game over");
            else
                if (fieldcount <= bombCount)
                    Console.WriteLine("Ai castigat!");

                
           
                return true;
        }
        public static void Main()
        {


            StreamReader reader = new StreamReader(@"../../date.in");
            CitireMatrice(out a, reader);
            n = a.GetLength(0);
            m = a.GetLength(1);
            b = new bool[n, m];
            fieldcount = n * m;


            PrintMatrix();
            Click(1, 4);

            Console.WriteLine("=======================");
            ConditionedPrint();
          










            return;
        }
    }
}
