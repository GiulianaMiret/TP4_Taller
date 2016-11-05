using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaDominio
    {
        public CapaDominio() { }

        //Llama al metodo Ejecutar de la Clase CapaPersistencia
        public string Ejecutar()
        {
            CapaPersistencia aux = new CapaPersistencia();
            return aux.Ejecutar();
        }
    }
}
