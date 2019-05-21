using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SelectionSort
    {
        static void FSelectionSort(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int min = a[i], p = i;
                for(int j=i+1;j<a.Length;j++)
                     if(a[j]<min)
                    {
                        min = a[j];
                        p = j;
                    }
                int aux = a[p];
                a[i] = a[p];
                a[p] = aux;
                

            }
        }
        static void Main()
        {

            Console.ReadKey();
            return;
        }
    }
}
