using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movimientos c = new Movimientos();
        out1:
            Console.WriteLine("Seleccione una cuenta:" + "\n" + "1.Caja de ahorro" + "\n" + "2.Cuenta corrientes" + "\n" + "3.Transferir" + "\n" + "0.Cancelar");
            double saldo;
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Seleccione operación:" + "\n" + "1.ver saldo" + "\n" + "2.debitar" + "\n" + "3.acreditar" + "\n" + "0.Cancelar");
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        case 1:
                            saldo = c.VerSaldoCajaAhorro();
                            Console.WriteLine("El saldo actual es: {0}", saldo);
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 2:
                            Console.WriteLine("Ingrese el saldo a debitar: ");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            try 
                            {
                                c.DebitarSaldoCajaAhorro(saldo);
                                Console.WriteLine("El saldo actual es: {0}", c.VerSaldoCajaAhorro());
                            }
                            catch(NoHaySuficienteSaldo e)
                            {

                                Console.WriteLine("El saldo actual no es suficiente {0}" + "\n" + "El saldo actual es: {1}", e.Message, c.VerSaldoCajaAhorro());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 3:
                            Console.WriteLine("Ingrese el saldo a acreditar: ");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            c.AcreditarSaldoCajaAhorro(saldo);
                            Console.WriteLine("El saldo a sido acreditado! Su saldo es {0}", c.VerSaldoCajaAhorro());
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 0: goto out1;
                    }
                    break;
                case 2:
                    Console.WriteLine("Seleccione operación:" + "\n" + "1.ver saldo" + "\n" + "2.debitar" + "\n" + "3.acreditar" + "\n" + "0.Cancelar");
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        case 1:
                            saldo = c.VerSaldoCuentaCorriente();
                            Console.WriteLine("El saldo actual es: {0}", saldo);
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 2:
                            Console.WriteLine("Ingrese el saldo a debitar: ");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            try 
                            {
                                c.DebitarSaldoCuentaCorriente(saldo);
                                Console.WriteLine("El saldo actual es: {0}", c.VerSaldoCuentaCorriente());
                            }
                            catch (NoHaySuficienteSaldo e)
                            {
                                Console.WriteLine("El saldo actual no es suficiente {0}" + "\n" + "El saldo actual es: {1}",e.Message, c.VerSaldoCuentaCorriente());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 3:
                            Console.WriteLine("Ingrese el saldo a acreditar: ");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            c.AcreditarSaldoCuentaCorriente(saldo);
                            Console.WriteLine("El saldo a sido acreditado! Su saldo es {0}", c.VerSaldoCuentaCorriente());
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 0: goto out1;
                    }
                    break;
                case 3:
                    Console.WriteLine("Seleccione operación:" + "\n" + "1. De cuenta corriente a caja de ahorro" + "\n" + "2. De caja de ahorro a cuenta corriente" + "\n" + "0.Cancelar");
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Ingrese el saldo a transferir :");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                c.TransferirCuentaCorrienteACajaAhorro(saldo);
                                Console.WriteLine("La tranferencia se ha realizado");
                                Console.WriteLine("El saldo en caja de ahorro es: {0}" + "\n" + "El saldo en cuenta corriente es: {1}", c.VerSaldoCajaAhorro(), c.VerSaldoCuentaCorriente());
                            }
                            catch (NoHaySuficienteSaldo e)
                            {
                                Console.WriteLine("La transferencia no se ha podido realizar {0}", e.Message);
                                Console.WriteLine("El saldo en cuenta corriente es: {0}", c.VerSaldoCuentaCorriente());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 2:
                            Console.WriteLine("Ingrese el saldo a transferir :");
                            saldo = Convert.ToDouble(Console.ReadLine());
                            try 
                            {
                                c.TransferirCajaAhorroACuentaCorriente(saldo);
                                Console.WriteLine("La tranferencia se ha realizado");
                                Console.WriteLine("El saldo en caja de ahorro es: {0}" + "\n" + "El saldo en cuenta corriente es: {1}", c.VerSaldoCajaAhorro(), c.VerSaldoCuentaCorriente());
                            }
                            catch (NoHaySuficienteSaldo e)
                            {
                                Console.WriteLine("La transferencia no se ha podido realizar {0}", e.Message);
                                Console.WriteLine("El saldo en caja de ahorro es: {0}", c.VerSaldoCajaAhorro());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            goto out1;
                        case 0: goto out1;
                    }
                    break;
                case 0: break;
                default:
                    Console.WriteLine("El numero ingresado es invalido, ingrese nuevamente");
                    Console.Clear();
                    goto out1;
                    
            }
        }
    }
}
