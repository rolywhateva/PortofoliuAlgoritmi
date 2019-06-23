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
        /*
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
                for (int i = 0; i < nou.Length; i++)
                    if (i < a.Length - b.Length)
                        nou[i] = 0;
                    else
                        nou[i] = b[i - (a.Length - b.Length)];

                b = nou;
            }
            int[] sum;
         
            sum = new int[Math.Max(a.Length, b.Length)];
            int carry = 0;
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                sum[i] = (a[i] + b[i] + carry) % 10;
                carry = (a[i] + b[i] + carry) / 10;
            }
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
        */
       static  void Reverse(int[] a)
        {
            int n = a.Length;
            for(int i=0;i<a.Length/2;i++)
            {
                int aux = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = aux;
            }


        }
        #region sum 
        static int[]  Sum(int[] a, int[] b)
        {
            Reverse(a);
            Reverse(b);
            int[] sum = new int[Math.Max(a.Length , b.Length)];
            int i = 0, carry = 0;
            while(i<a.Length&&i<b.Length)
            {
                sum[i] = (a[i] + b[i] + carry) % 10;
                carry = (a[i] + b[i] + carry) / 10;
                i++;

            }
            while(i<a.Length)
            {
                sum[i] = (a[i] + carry) % 10;
                carry = (a[i] + carry) / 10;
                i++;

            }
            while (i < b.Length)
            {
                sum[i] = (b[i] + carry) % 10;
                carry = (b[i] + carry) / 10;
                i++;

            }
            if(carry!=0)
            {
                int[] t = new int[sum.Length + 1];
                for (int j = 0; j < sum.Length; j++)
                    t[j] = sum[j];
                t[t.Length - 1] = 1;
                sum = t;

            }
            Reverse(sum);
            return sum;


        }
        #endregion
        static int[] concatenare(int[] a, int[] b)
        {
            int[] nou = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                nou[i] = a[i];
            for (int i = 0; i < b.Length; i++)
                nou[a.Length + i] = b[i];

            return nou;
        }
        #region produs 
        static int[] prodcif(int[] a, int cif)
        {
       
            Reverse(a);
            
            int n = a.Length;
            int carry = 0;

            int[] prod = new int[n];
            for(int i=0;i<n;i++)
            {
                 prod[i] = (a[i] * cif + carry) % 10;
                carry = (a[i] * cif + carry) / 10;

            }
       

            if (carry!=0)
            {
                int[] t = new int[n + 1];
                for (int i = 0; i < n; i++)
                    t[i] = prod[i];
                t[t.Length - 1] = carry;
                prod= t;
            }

            Reverse(prod);
            return prod;
        }
        static int Trim(ref int[] a )
        {
            int n = a.Length;
            if (a[n - 1] != 0)
                return 0;
            int nr = 0;
            while(n>1&&a[n-1]==0)
            {
                nr++;
                n--;
            }
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
                t[i] = a[i];
            a = t;
            return nr;
        }
        static int[] produs(int[] a, int[] b)
        {
            int nra = Trim(ref a);
            int nrb =Trim(ref b);
            int[] sum = new int[] {};
            int p = 0, n = a.Length, m = b.Length;
            for(int i=m-1;i>=0;i--)
            {
                int[] prodtemp = prodcif(a, b[i]);
                int[] temp = new int[prodtemp.Length + p];
                for (int j = 0; j< temp.Length; j++)
                    if (j <prodtemp.Length)
                        temp[j] = prodtemp[j];
                    else
                         temp[j] = 0;
                p++;
                prodtemp = temp;
                sum = Sum(sum, prodtemp);
            }
            if (nra + nrb != 0)
            {
                int[] toCat = new int[nra + nrb];
                sum = concatenare(sum, toCat);
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
        #endregion
        static void Main()
        {
            
            int[] a = DigitArray(11);
            int[] b = DigitArray(110);
            int[] s = Sum(a, b);
         //  Console.WriteLine(string.Join("",s));

            int[] c = DigitArray(12);
            int[] p = prodcif(c, 3);
            // Console.WriteLine(string.Join("", p));

            a = DigitArray(300);
            b = DigitArray(3);
             p = produs(a, b);
            Console.WriteLine(string.Join("",p));
    
          












            Console.ReadKey();
            return;
        }
    }
}
