using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
   public class OrdenamientoQuickSort
    {
        private static void QuickSort(int[] v, int iz, int de)
        {
            int m;
            if (de > iz)
            {
                m = divideyvenceras(v, iz, de);
                QuickSort(v, iz, m - 1);
                QuickSort(v, m + 1, de);
            }
        }

        public static void rapido(int[] v)
        {
            QuickSort(v, 0, v.Length - 1);
        }

        private static void cambiar(int[] plista, int i, int j)
        {
            int t;
            t = plista[i];
            plista[i] = plista[j];
            plista[j] = t;
        }
        private static int divideyvenceras(int[] v, int izq, int der)
        {
            int i, pivote;
            cambiar(v, (izq + der) / 2, izq);
            // el pivote es el de centro y se cambia con el primero
            pivote = v[izq];
            i = izq;
            for (int s = izq + 1; s <= der; s++)
                if (v[s] <= pivote)
                {
                    i++;
                    cambiar(v, i, s);
                }
            cambiar(v, izq, i);// se restituye el pivote donde debe estar
            return i; // retorna la posicion en que queda el pivote
        }
    }
}
