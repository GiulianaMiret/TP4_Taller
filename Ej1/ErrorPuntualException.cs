using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class ErrorPuntualException : ApplicationException
    {
        public ErrorPuntualException(string pMensaje) : base(pMensaje)
        { }
    }
}
