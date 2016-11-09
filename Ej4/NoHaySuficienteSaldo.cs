using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class NoHaySuficienteSaldo : Exception
    {
        public NoHaySuficienteSaldo(string pMensaje): base(pMensaje)
        { }
    }
}
