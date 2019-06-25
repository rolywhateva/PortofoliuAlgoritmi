using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laborator9
{
    class BacktrackingGeneralizat
    {
        struct pozitie
        {
            public int lin;
            public int col;
            public override string ToString()
            {
                return $"({lin},{col})";
            }
        }
        static void CitireMatrice(out int[,] a, StreamReader sr)
        {
            string[] tokens = sr.ReadToEnd().Split(new char[] { '\n' },StringSplitOptions.RemoveEmptyEntries);
            string[][] linetokens = new string[tokens.Length][];
            for (int i = 0; i < linetokens.Length; i++)
                linetokens[i] = tokens[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            a = new int[tokens.Length, linetokens[0].Length];
            for (int i = 0; i < linetokens.Length; i++)
                for (int j = 0; j < linetokens[i].Length; j++)
                        a[i, j] = int.Parse(linetokens[i][j]);
                  



        }
       static  int[] dx = { -1, 0, 1, 0 };
       static  int[] dy = { 0, 1, 0, -1 };
    
        static int n, m;
        static void bk(int[,] a, bool[,] b, pozitie[] st, int lindest, int coldest,int k,pozitie reper)
        {
            if (st[k].lin == lindest && st[k].col == coldest)
            {
               
                for (int i = 0; i <=k ; i++)
                    Console.WriteLine(st[i] + "\t");
                Console.WriteLine("==============");
                Console.ReadKey();
            }
            else
            {
            
                for (int i = 0; i < dx.Length; i++)
                {
                    pozitie nou;
                    nou.lin = reper.lin + dx[i];
                    nou.col = reper.col + dy[i];
                    if (nou.lin >= 0 && nou.col >= 0 && nou.lin < n && nou.col < m 
                        && a[nou.lin,nou.col]!=1&& !b[nou.lin, nou.col])
                    {

                        st[k + 1] = nou;
                        b[nou.lin, nou.col] = true;
                        bk(a, b, st, lindest, coldest, k + 1, nou);
                        b[nou.lin, nou.col] = false;
                     

                    }
                }
            }
               

                
            



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
            StreamReader reader = new StreamReader(@"..\..\date.in");
            int x, y, xdest, ydest;
            int[,] a;
            #region read
          
            string[] tokens = reader.ReadLine().Split(' ');
            x = int.Parse(tokens[0]);
            y = int.Parse(tokens[1]);

             tokens = reader.ReadLine().Split(' ');
            xdest = int.Parse(tokens[0]);
            ydest = int.Parse(tokens[1]);

            CitireMatrice(out a, reader);
            n = a.GetLength(0);
            m = a.GetLength(1);
            #endregion 
            //back
            pozitie[] st = new pozitie[n * m];
            int k = 0;
            bool[,] b = new bool[n, m];
            st[0].lin = x;
            st[0].col = y;
            b[x, y] = true;
            Afisare(a);
            bk(a, b, st, xdest, ydest, k, st[0]);








            return;
        }
    }
}
