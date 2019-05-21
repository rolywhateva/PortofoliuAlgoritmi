using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SortareSign
    {
        static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        static void SignSort(int[] a)
        {
            int neg = 0, zero = 0, poz = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] < 0)
                {


                    if (zero != 0)
                    {
                        a[neg] = a[i];

                        a[i] = a[neg + zero];
                        a[neg + zero] = 0;
                    }
                    else
                    {
                        int aux = a[i];
                        a[i] = a[neg];
                        a[neg] = aux;
                    }
                    neg++;

                }
                else 
                if (a[i] == 0)
                {
                   
                    int aux = a[neg+zero];
                    a[neg+zero] = a[i];
                    a[i] = aux;
                    zero++;

                }
            
                
            
        }
        static void Main()
        {
            int[] a;
            bool debug = true;
            
            if(debug)
            {

                //Here goes debug...
                a = new int[] { 4,-5,0,-6,7,0,0,0,-3,-4,0,0,-5 };
                Console.WriteLine("a=({0})", string.Join(",", a));
                SignSort(a);
                Console.WriteLine("a=({0})", string.Join(",", a));
                Console.ReadKey();
                return;
            }
            a = RandomArray(10, -100, 100);
            Console.WriteLine("a=({0})", string.Join(",", a));
            SignSort(a);
            Console.WriteLine("a=({0})", string.Join(",", a));
            
       
            Console.ReadKey();


            return;
        }
    }
}
