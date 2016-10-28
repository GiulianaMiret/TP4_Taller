using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class Usuario
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
    }
}
