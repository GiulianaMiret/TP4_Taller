using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {
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