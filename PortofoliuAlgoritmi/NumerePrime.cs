using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortofoliuAlgoritmi
{
    class NumerePrime
    {
        static bool Prim1(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;

        }
        static bool Prim2(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static bool Prim3(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static bool Prim4(int n)
        {
            if (n < 2 || n != 2 && n % 2 == 0)
                return false;
            for (int i = 3; i * i < n; i = i + 2)
                if (n % i == 0)
                    return false;
            return true;
        }
    
    static void Main()
    {
        Console.WriteLine(Prim1(13));
        Console.WriteLine(Prim2(13));
        Console.WriteLine(Prim3(13));
        Console.WriteLine(Prim4(13));
        Console.WriteLine(Prim4(9));
        Console.ReadKey();

        return;
    }
}
}

    

