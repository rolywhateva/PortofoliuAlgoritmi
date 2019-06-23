using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ReuniuneIntersectieSiDiferenta
    {
        static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        static int[] concatenare(int[] a, int[] b)
        {
            int[] nou = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                nou[i] = a[i];
            for (int i = 0; i < b.Length; i++)
                nou[a.Length + i] = b[i];

            return nou;
        }
        static int[] Reuniune(int[] a, int [] b)
        {
            int n = a.Length, m = b.Length;
            int[] c = concatenare(a, b);
            int[] v = new int[n+m];
            int nr = 0;
            for(int i=0;i<c.Length;i++)
            {
                bool found = false;
                for (int j = 0; j < nr && !found; j++)
                    if (v[j] == c[i])
                        found = true;
                if(!found)
                {
                    v[nr++] = c[i];
                }
            }
            int[] t = new int[nr];
            for (int i = 0; i < t.Length; i++)
                t[i] = v[i];
            return t;

        }
        static int[] Intersectie(int[] a, int[] b)
        {
            int n = a.Length, m = b.Length;
            int[] v = new int[Math.Min(n, m)];
            int nr = 0;
            for(int i=0;i<n;i++)
            {
                bool found = false;
                for (int j = 0; j < m && !found; j++)
                    if (b[j] == a[i])
                        found = true;
                if (found)
                    v[nr++] = a[i];
            }
            int[] t = new int[nr];
            for (int i = 0; i < nr; i++)
                t[i] = v[i];
            return t;
        }
     
        static int[] Diferenta(int[] a, int [] b)
        {

            int n = a.Length, m = b.Length;
            int[] v = new int[a.Length];
            int nr = 0;
            for (int i = 0; i<n;i++)
            {
                bool found = false;
                for (int j = 0; j < m && !found; j++)
                    if (b[j] == a[i])
                        found = true;
                if (!found)
                    v[nr++] = a[i];
            }
            int[] t = new int[nr];
            for (int i = 0; i < nr; i++)
                t[i] = v[i];
            return t;

        }
        static void Main()
        {
            int[] a = new int[] {3,2};
            int[] b = new int[] {3};
            Console.WriteLine(string.Join(" ",Reuniune(a,b)));
            Console.WriteLine(string.Join(" ", Intersectie(a, b)));
            Console.WriteLine(string.Join(" ", Diferenta(a, b)));


            Console.ReadKey();
            return;
        }
    }
}
