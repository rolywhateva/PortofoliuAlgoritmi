using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class BubbleSort
    {
        static void FBubbleSort(int[] a)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                    if (a[i] > a[i + 1])
                    {
                        int aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                        sorted = false;
                    }
            } while (!sorted);
        }
        static void FBubbleSort2(int[] a)
        {
            bool sorted;
            int k = 0;
            do
            {
                sorted = true;
                for (int i = 0; i < a.Length - k; i++)
                    if (a[i] > a[i + 1])
                    {
                        int aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                        sorted = false;
                    }
                k++;


            } while (!sorted);
        }

        static void Main()
        {


            return;
        }
    }
}
