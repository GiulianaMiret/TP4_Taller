using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public static class Matematica
    {
        public static double  Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                Exception dcero = new DivisionPorCeroException("Error numero: 290395, La division por cero no es posible");
                throw dcero;
            }

            return pDividendo / pDivisor;
        }
    }
}
