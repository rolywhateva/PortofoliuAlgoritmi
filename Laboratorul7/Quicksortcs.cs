using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul7
{
    class Quicksortcs
    {
        static Random rnd = new Random();
        static int partition(int[] arr, int low,
                                 int high)
        {

            int pivot = high;
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= arr[pivot])
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[pivot];
            arr[pivot] = temp1;

            return i + 1;
        }
      static   int partitionrandom(int[] arr, int low, int high)
        {
            int pivot = rnd.Next(low, high + 1);
            int aux = arr[high];
            arr[high] = arr[pivot];
            arr[pivot] = aux;
            return partition(arr, low, high);
        }

      
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

              
                int pi = partitionrandom(arr, low, high);

             
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
  
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        static void Main()
        {
            int[] a = { -3, 4, 0, -9, -8, 8, 7, -2, 3, 4, 10, -2 };
            quickSort(a, 0, a.Length-1 );
            printArray(a, a.Length);


            return;
        }
    }
}
