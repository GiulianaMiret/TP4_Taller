using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {   
        //Esta clase lanza la primer Excepcion que esta en su constructor
        //por lo que el metodo Ejecutar no se llega a ejecutar
        //Esta excepcion es tratada en la CapaVista
        public CapaPersistencia()
        {
            ErrorPuntualException unaExcepcion = new ErrorPuntualException("Error: "+Convert.ToString(DateTime.Now));
            throw unaExcepcion;
        }

        public string Ejecutar()
        {
            return "";
        }
    }
}