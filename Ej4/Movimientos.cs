using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Movimientos
    {
        private Cuentas icuentas;

        public Movimientos()
        {
            icuentas = new Cuentas();
        }

        public double VerSaldoCuentaCorriente()
        {
            Cuenta cuenta = icuentas.CuentaCorriente;
            return cuenta.Saldo;
        }

        public double VerSaldoCajaAhorro()
        {
            Cuenta cuenta = icuentas.CajaAhorro;
            return cuenta.Saldo;
        }

        public void DebitarSaldoCajaAhorro(double saldo)
        {
            Cuenta cuenta = icuentas.CajaAhorro;
            cuenta.DebitarSaldo(saldo);
        }

        public void DebitarSaldoCuentaCorriente(double saldo)
        {
            Cuenta cuenta = icuentas.CuentaCorriente;
            cuenta.DebitarSaldo(saldo);
         }

        public void AcreditarSaldoCuentaCorriente(double saldo)
        {
            Cuenta cuenta = icuentas.CuentaCorriente;
            cuenta.AcreditarSaldo(saldo);
        }

        public void AcreditarSaldoCajaAhorro(double saldo)
        {
            Cuenta cuenta = icuentas.CajaAhorro;
            cuenta.AcreditarSaldo(saldo);
        }

        public void TransferirCuentaCorrienteACajaAhorro(double saldo)
        {
            Cuenta cajaAhorro = icuentas.CajaAhorro;
            Cuenta cuentaCorriente = icuentas.CuentaCorriente;
            cuentaCorriente.DebitarSaldo(saldo);
            cajaAhorro.AcreditarSaldo(saldo);
        }

        public void TransferirCajaAhorroACuentaCorriente(double saldo)
        {
            Cuenta cajaAhorro = icuentas.CajaAhorro;
            Cuenta cuentaCorriente = icuentas.CuentaCorriente;
            cajaAhorro.DebitarSaldo(saldo);
            cuentaCorriente.AcreditarSaldo(saldo);
        }
    }
}
