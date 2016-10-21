using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {
        public string Ejecutar()
        {
            ErrorPuntualException unaExcepcion = new ErrorPuntualException("Excepcion de la capa Persistencia: " + Convert.ToString(DateTime.Today));
            throw unaExcepcion;
        }
    }
}