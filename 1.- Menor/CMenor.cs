using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor
{
    class CMenor
    {
        public int MenorN(int[] x, int n, int Menor)
        {
            if (n == 0)
            {
                if (Menor > x[n])
                {
                    return x[0];
                }
                else
                {
                    return Menor;
                }
            }
            else
            {
                if (Menor > x[n])
                {
                    return MenorN(x, n - 1, x[n]);
                }
                else
                {
                    return MenorN(x, n - 1, Menor);
                }
            }
        }
    }
}
