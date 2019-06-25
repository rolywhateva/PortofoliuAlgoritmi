using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul14
{
    struct  Data
    {
      public   int lin;
      public   int col;
        public int v;
        public Data(int lin,int col, int v)
        {
            this.lin = lin;
            this.col = col;
            this.v = v;
        }
        public override string ToString()
        {
            return $"a[{lin},{col}]={v}";

        }
    }
}
