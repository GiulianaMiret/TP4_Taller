using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaVista
    {
        public CapaVista() { }

        public string Ejecutar()
        {
            CapaControlador aux = new CapaControlador();
            try
            {
                return aux.Ejecutar();
            }
            catch (Exception exception)
            {
                return ("Excepcion capa Vista: " + exception);
            }
        }
    }
}
