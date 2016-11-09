using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class ComparadorCorreoElectronico : IComparer<Usuario>
    {

        //Compara los usuarios segun su correo electronico
        public int Compare(Usuario usuario1, Usuario usuario2)
        {
            return usuario1.CorreoElectronico.CompareTo(usuario2.CorreoElectronico);
        }
    
    }
}
