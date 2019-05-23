using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    class CautareBinara
    {
        static bool BS(int[] v, int st, int dr, int x)
        {
            int m = (st + dr) / 2;
            if (st < dr)
            {
                if (v[m] == x)
                    return true;
                else
                if (v[m] > x) return BS(v, st, m - 1, x);
                else
                      if (v[m] < x) return BS(v, m + 1, dr, x);
            }
            return false;

        }
    }
}
