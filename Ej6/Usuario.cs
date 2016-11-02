using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Usuario : IComparable<Usuario>
    {
        public string iCodigo { get; set; }
        public string iNombreCompleto { get; set; }
        public string iCorreoElectronico { get; set; }

        public string  Codigo
        { get { return this.iCodigo; }
        }

        public string  NombreCompleto
        { get { return this.iNombreCompleto; }
        }

        public string  CorreoElectronico
        { get { return this.iCorreoElectronico; }
        }

        public int CompareTo(Usuario other)
        {
           return this.Codigo.CompareTo(other.Codigo);

            ////if (this.Codigo == other.Codigo)
            //    { return 0; }
            //else
            //{
            //    if (this.Codigo <= other.Codigo)
            //    {
            //        return -1;
            //    }
            //    else { }


           

            throw new NotImplementedException();
        }
    }
}
