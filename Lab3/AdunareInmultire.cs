using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class AdunareInmultire
    {
        static int[] DigitArray(int a)
        {
            if (a == 0)
                return new int[] { 0 };

            int nrCifre = (int)Math.Ceiling(Math.Log10(a));
            if (nrCifre == 0)
                nrCifre++;

            int[] digit = new int[nrCifre];
            for (int i = digit.Length - 1; i >= 0; i--)
            {
                digit[i] = a % 10;
                a = a / 10;
            }
            return digit;

        }
        static int[] Sum(int[] a, int[] b)
        {
            if (a.Length < b.Length)
            {
                int[] aux = a;
                a = b;
                b = aux;
            }
            if (b.Length < a.Length)
            {
                int[] nou = new int[a.Length];
                /*
                for (int i = 0; i < a.Length - b.Length; i++)
                  
                    nou[i] = 0;
                for (int i = a.Length - b.Length ; i < nou.Length; i++)
                    nou[i] = b[i-(a.Length-b.Length)];
                 */
                for (int i = 0; i < nou.Length; i++)
                    if (i < a.Length - b.Length)
                        nou[i] = 0;
                    else
                        nou[i] = b[i - (a.Length - b.Length)];

                b = nou;




            }
            int[] sum;
            // Console.WriteLine(string.Join("  ", b));
            sum = new int[Math.Max(a.Length, b.Length)];
            int carry = 0;
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                sum[i] = (a[i] + b[i] + carry) % 10;
                carry = (a[i] + b[i] + carry) / 10;
            }
            //Console.WriteLine(string.Join("  ", sum));
            if (carry != 0)
            {
                int[] nou = new int[sum.Length + 1];
                nou[0] = carry;
                for (int i = 1; i < nou.Length; i++)
                    nou[i] = sum[i - 1];
                sum = nou;
            }
           
            return sum;


        }
        /*
      static int[] prod(int[] a, int[] b)
        {
            int[] prod = new int[2 * Math.Max(a.Length,b.Length) + 1];
            int carry = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int[]  prodpart = new int[Math.Min(a.Length, b.Length)+a.Length-1-i];
                for (int j = b.Length - 1; j >= 0; j--)
                {
                      prodpart[prod.Length]
                }
                    
                        
                        
            }
        }
        */
        static void Main()
        {
            int[] a = DigitArray(7888);
            int[] b = DigitArray(844);
            int[] s = Sum(a, b);
            // Array.Reverse(s);
            Console.WriteLine("{0}+{1}={2}",
                                                  string.Join("", a),
                                                   string.Join("", b),
                                                    string.Join("", s));




            Console.ReadKey();
            return;
        }
    }
}
