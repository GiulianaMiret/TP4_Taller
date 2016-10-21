using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaDominio
    {
        public string Ejecutar()
        {
            CapaPersistencia aux = new CapaPersistencia();
            return aux.Ejecutar();
        }
    }
}
