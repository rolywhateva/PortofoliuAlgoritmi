using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SumaProdusNorma
    {
        static int[] RandomArray(int n, int min =0, int max =100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        static void Main(string[] args)
        {

            int[] a = RandomArray(6, -100, 100);
            Console.WriteLine("a=({0})", string.Join(",", a));

            int s = 0;
            for (int i = 0; i < a.Length; i++)
                s = s + a[i];
            Console.WriteLine("Suma elementelor :" + s);
            int p = 1;
            for (int i = 0; i < a.Length; i++)
                p = p * a[i];
            Console.WriteLine("Produsul elementelor:" + p);
             double norma = 0;
            for (int i = 0; i < a.Length; i++)
                norma = norma + a[i] * a[i];
            norma = Math.Sqrt(norma);
            Console.WriteLine("Norma euclidiana a vectorului :{0:F3}",norma);



            Console.ReadKey();
        }
    }
}
