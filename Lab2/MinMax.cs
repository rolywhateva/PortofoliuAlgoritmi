using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class MinMax
    {
        static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        static  int  Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        static  int Min(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] <min)
                    min= a[i];
            return min;
        }
        static void MaxMin(int[] a,  out int min, out int max)
        {
            min = max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] < min)
                    min = a[i];
                else
                     if (a[i] > max)
                    max = a[i];
        }
        static void Main()
        {
            int[] a = RandomArray(10, -100, 100);
            Console.WriteLine("a=({0})",string.Join(",",a));
            int min, max;
            MaxMin(a, out min, out max);
           
            
            Console.WriteLine("Min:{0}\nMax:{1}", min, max);
            Console.ReadKey();
           

            return;
        }
    }
}
