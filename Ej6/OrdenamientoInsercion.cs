using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class OrdenamientoInsercion
    {
        public static void insercion(int[] plista)
        {
            int n = plista.Length;
            for (int i = 1; i <= n - 1; i++)
            {
                int x = plista[i];
                int j = i - 1;
                while (j >= 0 && x < plista[j])
                {
                    plista[j + 1] = plista[j];
                    j = j - 1;
                }
                plista[j + 1] = x;
            }
        }
    }
}
