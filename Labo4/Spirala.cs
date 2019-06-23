using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo4
{
    class Spirala
    {
        #region Citire
        static void CitireDimensiuni(out int n, out int m)
        {
            string[] ints;
            n = 0; m = 0;
            bool ok;
            do
            {
                ok = true;

                Console.WriteLine("Dati numarul de linii si de coloane:");
                ints = Console.ReadLine().Split(new char[] { ' ', ',', '-', 'x' }, StringSplitOptions.RemoveEmptyEntries);
                ok = ints.Length == 2
                     && int.TryParse(ints[0], out n)
                     && int.TryParse(ints[1], out m)
                     && n * m != 0;

                if (!ok)
                {
                    Console.WriteLine("Eroare!Introduceti din nou!");
                }
            } while (!ok);
        }
        static void CitireMatrice(out int[,] a, int n, int m)
        {
            bool ok;
            string[] matrice = new string[n];
            string[] ints;
            a = new int[n, m];
            do
            {
                ok = true;
                Console.WriteLine("Introduceti o matrice de {0}x{1}", n, m);
                for (int i = 0; i < n; i++)
                    matrice[i] = Console.ReadLine().Trim();
                for (int i = 0; i < n && ok; i++)
                {


                    ints = matrice[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    ok = ints.Length == m;
                    for (int j = 0; j < m && ok; j++)
                        ok = int.TryParse(ints[j], out a[i, j]);
                    if (!ok)
                        Console.WriteLine("Eroare la linia {0}!Reintroduceti!", i + 1);


                }
            } while (!ok);
        }
        #endregion

        static void Afisare(int[,] a, int n, int m, string sep)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0,6}", a[i, j]);
                Console.Write(sep);
            }
        }
        static void Afisare2(int[,] a, int n, int m, string sep)
        {

            for (int i = 0; i < m; i++)
                Console.Write("{0,6}", a[0, i]);
            Console.Write(sep);
            for (int i = m - 1; i >= 0; i--)
                Console.Write("{0,6}", a[1, i]);





        }
        static void AfisareSpirala(int[,] a, int n, int m)
        {
            if (n == 1 || m == 1)
                Afisare(a, n, m, "\n");
            else
               if (n == 2)
                Afisare2(a, n, m, "\n");
            else
            {
                int contor = Math.Min(n, m);
                contor = contor / 2 + contor % 2;
                for (int c = 0; c < contor; c++)
                {
                    for (int i = c; i < m - c; i++)
                        Console.Write(a[c, i] + "\t");

                    for (int i = c + 1; i < n - c; i++)
                        Console.Write(a[i, m - 1 - c] + "\t");

                    for (int i = m - c - 2; i >= c + 1; i--)
                        Console.Write(a[n - c - 1, i] + "\t");
                    for (int i = n - c - 2; i >= c + 1; i--)
                        Console.Write(a[i, c] + "\t");



                }
            }



        }




        static void Main(string[] args)
        {

            int[,] a;
            int n, m;
            CitireDimensiuni(out n, out m);
            CitireMatrice(out a, n, m);

            Console.Clear();
            Console.WriteLine("Matricea de {0} x {1}:", n, m);
            Afisare(a, n, m, "\n");
            Console.WriteLine("se parcurge in spirala asa :");

        }
    }
}

