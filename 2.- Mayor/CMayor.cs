using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor
{
    class CMayor
    {
        public int MayorN(int[] x, int n, int Mayor)
        {
            if (n == 0)
            {
                if (Mayor < x[n])
                {
                    return x[0];
                }
                else
                {
                    return Mayor;
                }
            }
            else
            {
                if (Mayor < x[n])
                {
                    return MayorN(x, n - 1, x[n]);
                }
                else
                {
                    return MayorN(x, n - 1, Mayor);
                }
            }
        }
    }
}
