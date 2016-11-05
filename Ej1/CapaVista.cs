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

        //El metodo Ejecutar es llamado por la Clase Program, el mismo
        //llama al metodo Ejecutar de la capa Controlador
        //y trata la excepcion que viene de la CapaPersistencia,
        //lanzando una nueva excepcion
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
