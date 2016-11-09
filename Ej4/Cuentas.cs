using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        public Cuentas()
        {
            this.iCliente = new Cliente("DNI", "38871203", "Gastal Valeria");
            this.iCuentaCorriente = new Cuenta(0, 0);
            this.iCajaAhorro = new Cuenta(0, 0);
        }

        public Cuenta CuentaCorriente { get { return this.iCuentaCorriente; } }

        public Cuenta CajaAhorro { get { return this.iCajaAhorro; } }
    }
}
