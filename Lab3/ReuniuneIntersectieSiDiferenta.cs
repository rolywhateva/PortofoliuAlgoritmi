using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ReuniuneIntersectieSiDiferenta
    {
        static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];
            for (int i = 0; i < toReturn.Length; i++)
                toReturn[i] = rnd.Next(min, max + 1);
            return toReturn;
        }
        
        static void Main()
        {


            Console.ReadKey();
            return;
        }
    }
}
