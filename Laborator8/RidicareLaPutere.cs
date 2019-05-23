using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    class RidicareLaPutere
    {
        static int Putere(int a, int b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;
            else
                if (b % 2 == 0)
                return a * Putere(a, b / 2);
            else
                return a * Putere(a, b - 1);

        }
    }
}
