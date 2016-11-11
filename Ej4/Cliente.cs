using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Cliente
    {
        private TipoDocumento iTipoDocumento;
        private string iNroDocumento;
        private string iNombre;

        public Cliente(string pTipoDocumento, string pNroDocumento, string pNombre)
        {
            switch (pTipoDocumento)
            {
                case "DNI":
                    this.iTipoDocumento = TipoDocumento.DNI;
                    break;
                case "CUIL":
                    this.iTipoDocumento = TipoDocumento.CUIL;
                    break;
                case "CUIT":
                    this.iTipoDocumento = TipoDocumento.CUIT;
                    break;
                case "LC":
                    this.iTipoDocumento = TipoDocumento.LC;
                    break;
                case "LE":
                    this.iTipoDocumento = TipoDocumento.LE;
                    break;

            }
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
        }

        public TipoDocumento TipoDocumento { get { return this.iTipoDocumento; } }

        public string NroDocumento { get { return this.iNroDocumento; } }

        public string Nombre { get { return this.iNombre; } }
    }
}
