using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacion
    {
        public string Ejecutar()
        {
            CapaDominio aux = new CapaDominio();
            try
            {
                return aux.Ejecutar();
            }
            catch (Exception exception)
            {
                exception = new CapaAplicacionException("Segunda Excepcion - " + exception);
                throw exception;
            }
        }
    }
}
