using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Fachada
    {
        public Fachada()
        {
            //Contructor
        }
        public double Dividir(int a, int b)
        {
           return Matematica.Dividir(a, b);
        }
    }
}
