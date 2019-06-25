using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laboratorul14
{
    class Program
    {
        static void CitireMatrice(out int[,] a, StreamReader sr)
        {
            string[] tokens = sr.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[][] linetokens = new string[tokens.Length][];
            for (int i = 0; i < linetokens.Length; i++)
                linetokens[i] = tokens[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            a = new int[tokens.Length, linetokens[0].Length];
            for (int i = 0; i < linetokens.Length; i++)
                for (int j = 0; j < linetokens[i].Length; j++)
                    a[i, j] = int.Parse(linetokens[i][j]);


        }
        static int startx, starty, endx, endy, n, m;
        static Coada coada = new Coada();
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../date.in");
            string[] tokens = reader.ReadLine().Trim().Split(' ');
            startx = int.Parse(tokens[0]);
            starty = int.Parse(tokens[1]);
            tokens = reader.ReadLine().Trim().Split(' ');
            endx = int.Parse(tokens[0]);
            endy = int.Parse(tokens[1]);



            int[,] a;
            CitireMatrice(out a, reader);
            n = a.GetLength(0);
            m = a.GetLength(1);
            Afisare(a);
            bool[,] b = new bool[n, m];
            b[startx, starty] = true;
            coada.Add(new Data(startx, starty, 1));
            a[startx, starty] = 1;
            Adancime(a, b);
            Console.WriteLine("=====================");
            Afisare(a);
            Console.WriteLine("======================");
            Console.WriteLine(a[endx, endy]);

            






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
        private static void Adancime(int[,] a, bool[,] b)
        {
            while (coada.n != 0)
            {
                Data removed = coada.Remove();
                Console.WriteLine(removed);
                int[] dx = { -1, 0, 1, 0 };
                int[] dy = { 0, 1, 0, -1 };
                for (int i = 0; i < dx.Length; i++)
                {
                    Data nou = new Data(removed.lin + dx[i], removed.col + dy[i], removed.v + 1);
                    if (nou.lin >= 0 && nou.col >= 0 && nou.lin < n && nou.col < m
                        &&a[nou.lin,nou.col]==0&&!b[nou.lin,nou.col])
                    {
                        b[nou.lin, nou.col] = true;
                        a[nou.lin, nou.col] = nou.v;
                        coada.Add(nou);
                    }
                }
            
            }
        }
    }
}
