using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class ElementeIdentice
    {
        /*[Se dau 5 valori întregi a,b,c,d şi e. 
         * Construiţi un algoritm care identifică următoarele cazuri: 
         * 1.) Există 2 valori identice, 
         * 2.) Există 2 cȃte 2 valori identice, 
         * 3.) Există 3 valori identice, 
         * 4.) Există 3valori identice şi celelalte 2 sunt de asemena identice, 
         * 5.) Există 4 valori identice 
         * 6.) Toate valorile sunt identice] 
         * Să se verifice dacă valorile pot fi elementele consecutive ale unei 
         * progresii aritmetice cu raţia 1.
         * 
         * 
         * 
         * */
        static void Main(string[] args)
        {
            int[] a = new int[] { 2,2,2,3,3};
         
            for(int i=0;i<a.Length-1;i++)
            {
                int min = a[i];
                int pmin = i;
                for(int j=i+1;j<a.Length;j++)
                     if(a[j]<min)
                    {
                        min = a[j];
                        pmin = j;
                    }
                int aux = a[i];
                a[i] = a[pmin];
                a[pmin] = aux;
            }


           


            if (a[0] == a[a.Length - 1])
                Console.WriteLine("Toate valorile sunt egale cu {0}.", a[0]);
            else
                 if (a[1] == a[a.Length - 1] || a[a.Length - 2] == a[0])
                Console.WriteLine("Exista patru valori egale cu {0}.", a[1]);
            else
                  if ((a[0] == a[2] && a[3] == a[4]) || (a[2] == a[4] && a[0] == a[2]))
                Console.WriteLine("Exista 3 valori identice si alte 2  identice");
            else
                if (a[0] == a[2] || a[1] == a[3] || a[2] == a[4])
                Console.WriteLine("Exista trei valori identice");
              else 
                 if (a[1] == a[2] && a[3] == a[4])
                Console.WriteLine("Exista 2 cate doua valori identice");
            else
                if (a[1] == a[2] ^ a[3] == a[4])
                Console.WriteLine("Exista 2 valori identice.");

            Console.ReadKey();











        }
    }
}
