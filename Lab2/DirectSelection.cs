using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class DirectSelection
    {
        static void  FDirectSelection(int[] a)
        {
            for(int i=0;i<a.Length;i++)
                 for(int j=i+1;j<a.Length;j++)
                     if(a[i]<a[j])
                    {
                        int aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }

        }
        static void Main()
        {

            Console.ReadKey();
            return;
        }
    }
}
