using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    class MinMaxDivideAndConquer
    {
        static int Maxim(int[] v, int st, int dr)
        {
            if (st <= dr)
            {
                if (st == dr)
                    return v[st];
                else
                {
                    int m = (st + dr) / 2;
                    int max1 = Maxim(v, st, m - 1);
                    int max2 = Maxim(v, m + 1, dr);
                    return Math.Max(max1, max2);
                }
            }
            return 0;
        }
        static int Minim(int[] a, int st, int dr)
        {
            if (st < dr)
            {
                int m = (st + dr) / 2;
                int min1 = Minim(a, st, m-1);
                int min2 = Minim(a, m+1, dr);
                return Math.Min(min1, min2);
            }
            else
                return a[st];
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            int n = a.Length;
         
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next() % 100;
         
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(Minim(a,0,n-1));
        }
    }
}
