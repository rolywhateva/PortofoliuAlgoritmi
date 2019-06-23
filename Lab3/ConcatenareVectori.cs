using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ConcatenareVectori
    {
        static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        static void WriteArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0}\t", a[i]);
            Console.WriteLine();
        }
        static int[] concatenare(int[] a , int[] b)
        {
            int[] nou = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                nou[i] = a[i];
            for (int i = 0; i < b.Length; i++)
                nou[a.Length+i] = b[i];
          
            return nou;
        }
        static void Main()
        {
            int[] a = RandomArray(10, -10, 10);
            int[] b = RandomArray(4, -30,-20);
            WriteArray(a);
            WriteArray(b);
           int[] c = concatenare( a, b);
            WriteArray(c);



            Console.ReadKey();
            return;
        }




          
    }
}
