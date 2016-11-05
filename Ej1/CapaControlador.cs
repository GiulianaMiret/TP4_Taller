using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaControlador
    {
        public CapaControlador() { }

        public string Ejecutar()
        {
            CapaAplicacion aux = new CapaAplicacion();

            //Llama al metodo Ejecutar de la Capa Aplicacion
            return aux.Ejecutar();
        }
    }
}
