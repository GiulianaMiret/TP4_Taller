using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta(double pAcuerdo)
        {
            this.iSaldo = 0;
            this.iAcuerdo = pAcuerdo;
        }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iSaldo = pSaldoInicial; //saldoInicial mayor a cero?
            this.iAcuerdo = pAcuerdo;
        }

        public double Saldo { get { return this.iSaldo; } }

        public double Acuerdo { get { return this.iAcuerdo; } }

        public void AcreditarSaldo(double pSaldo)
        { this.iSaldo += pSaldo; }

        public void DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
            }
            else
            {
                if (this.iSaldo + this.iAcuerdo >= pSaldo)
                {
                    this.iAcuerdo -= (pSaldo - iSaldo);
                    this.iSaldo = 0;
                }
                else
                {
                    Exception faltaSaldo = new NoHaySuficienteSaldo("Error numero: 290395, El saldo no es suficiente");

                    throw faltaSaldo;
                }
            }
        }
    }
}
