using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacion
    {
        public CapaAplicacion () { }

        //Llama al metodo Ejecutar de la Clase CapaDominio y trata la excepcion
        //lanzando una nueva Excepcion

        public string Ejecutar()
        {
            CapaDominio aux = new CapaDominio();
            try
            {
                return aux.Ejecutar();
            }
            catch (Exception exception)
            {
                exception = new CapaAplicacionException("Excepcion de la capa Aplicacion: "+Convert.ToString(DateTime.Now), exception);
                //otra forma es asi: (si la excepcion no tiene el parametro InnerException)
                //exception = new CapaAplicacionException("Segunda Excepcion - ").InnerException;
                throw exception;
            }
        }
    }
}
