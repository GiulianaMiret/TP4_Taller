using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class ApplicationException : Exception
    {
        public ApplicationException (string pMensaje) : base (pMensaje)
        { }
    }
}