using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class OrdenamientoBurbuja
    {
        public static void burbuja(int[] plista)
        {
            int n = plista.Length;
            for (int i = 0; i <= n - 2; i++)
                for (int j = n - 1; j > i; j--)
                    if (plista[j - 1] > plista[j])
                        cambiar(plista, j - 1, j);
        }
        private static void cambiar(int[] plista, int i, int j)
        {
            int t;
            t = plista[i];
            plista[i] = plista[j];
            plista[j] = t;
        }
    }
}
