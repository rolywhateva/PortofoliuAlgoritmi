using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Labo4
{
   public  class OperatiiCuMatrici
    {
        static int[,] randomMatrice(int n, int m)
        {
            int[,] a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rnd.Next(-10, 10);
            return a;

        }
        static int[,] Add(int[,] a, int[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            {
                Console.WriteLine("Matricele  nu se pot aduna.");
                return null;
            }
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] c = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    c[i, j] = a[i, j] + b[i, j];
            return c;
        }

        static int[,] Prod(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine("Matricele  nu se pot inmulti.");
                return null;
            }
            int n = a.GetLength(0);
            int m = b.GetLength(1);
            int[,] c = new int[n, m];
            for(int i=0;i<n;i++)
                 for(int j=0;j<m;j++)
                {
                    int sum = 0;
                    for (int z = 0; z < a.GetLength(0); z++)
                        sum += a[i, z] * b[z, j];
                    c[i, j] = sum;
                }


            return c;
        }
        static bool  Incluziune(int[,] a ,int[,] b)
        {
            int na = a.GetLength(0), ma = a.GetLength(1);
            int nb = b.GetLength(0), mb = b.GetLength(1);
            bool inclus = false;
            for(int i=0;i<=na-nb&&!inclus;i++)
               for(int j=0;j<=ma-mb&&!inclus;j++)
                {
                    if(a[i,j]==b[0,0])
                    {
                        bool ok = true;
                        for (int z = i; z < i + nb && ok; z++)
                            for (int k = j; k < j + mb && ok; k++)
                                if (b[z - i, k - j] != a[z,k])
                                {
                                    Console.WriteLine("({0}),({1})",i+","+j,z+","+k);
                                    ok = false;
                                }
                        if (ok)
                            inclus = true;
                            

                                     
                    }
                }
            return inclus;
        }
        static bool Incluziune2(int[,] a, int[,] b)
        {
            int na = a.GetLength(0), ma = a.GetLength(1);
            int nb = b.GetLength(0), mb = b.GetLength(1);
            bool inclus = false;
            int ib = 0, jb = 0;
            for(int i=0;i<na&&!inclus;i++)
                for(int j=0;j<ma&&!inclus;j++)
                    if(a[i,j]==b[ib,jb]&&a[i-ib,j-jb]==b[0,0])
                    {
                        jb++;
                        if(jb>=mb)
                        {
                         
                            
                            jb = 0;
                            ib++;
                            if(ib>=nb)
                                inclus = true;
                            
                        }
                    }else
                    if(a[i,j]!=b[ib,jb]&&a[i-ib,j-jb]==b[0,0])
                    {
                        jb = 0;
                        ib = 0;
                        j--;

                    }
            return inclus;
                

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
        static void CitireMatrice(out int[,] a,StreamReader sr)
        {
            string[] tokens = sr.ReadLine().Split(' ');
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);
            a = new int[n, m];
            for(int i=0;i<n;i++)
            {
                tokens = sr.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    a[i, j] = int.Parse(tokens[j]);


            }

        }
        static void Main()
        {

            bool debug1 = false, debug2 = true;

            #region debug Add si Mult
            if (debug1)
            {
                int[,] a = randomMatrice(2, 3);
                int[,] b = randomMatrice(3, 2);
                // int[,] sum = Add(a, b);
                int[,] prod = Prod(a, b);
                Afisare(a);
                Console.WriteLine();
                Console.WriteLine("================================");
                Afisare(b);
                Console.WriteLine();
                Console.WriteLine("================================");
                Console.WriteLine("sum:");
                //   Afisare(sum);
                Console.WriteLine("Prod:");


                Afisare(prod);
                Console.ReadKey();
            }
            #endregion
            #region Debug incluzine
            if(debug2)
            {
                StreamReader sr = new StreamReader("../../Matrice.txt");
                int[,] a, b;
                CitireMatrice(out a, sr);
                CitireMatrice(out b, sr);
                Console.WriteLine();
                Console.WriteLine("================================");
                Afisare(a);
                Console.WriteLine();
                Console.WriteLine("================================");
                Afisare(b);
                bool inc = Incluziune2(a, b);
                Console.WriteLine("{0}", inc ? "Da" : "Nu");


            }
            #endregion

            Console.ReadKey();



            return;
        }
    }
}
