using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class ComparadorNombreyCodigo : IComparer<Usuario>
    {
        //Compara los usuarios segun el nombre y el codigo
        //Es decir, los ordena pimero por nombre y despues por codigo

        public int Compare(Usuario usuario1, Usuario usuario2)
        {
            string aux = usuario1.NombreCompleto + usuario1.Codigo;

            string aux2 = usuario2.NombreCompleto + usuario2.Codigo;

            return aux.CompareTo(aux2);
        }
    }
}
