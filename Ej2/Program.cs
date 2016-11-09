using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada f = new Fachada();
            out1:
            Console.WriteLine("Bienvenido! \n 1. Dividir \n0. Salir");
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1: 
                        Console.WriteLine("Ingrese Divisor: ");
                        int div = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingrese Dividendo: ");
                        int divid = Convert.ToInt16(Console.ReadLine());
                        try
                       {
                        double resultado = f.Dividir(div, divid);
                        Console.WriteLine("El resultado es: ", resultado);
                        goto out1;
                        }
                        catch (DivisionPorCeroException e)
                    {  
                        Console.WriteLine("No se puede dividir por cero. {0}", e.Message);
                        goto out1;
                    }
            }
        }
    }
}
