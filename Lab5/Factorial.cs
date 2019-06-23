using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Factorial
    {
        static int  factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);
            else
                return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(0)+ "  " + factorial(1) + " "+factorial(3));
        }
    }
}
