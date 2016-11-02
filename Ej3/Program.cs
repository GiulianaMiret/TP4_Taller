using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            string linea;
            string ruta = null;
            Console.WriteLine("Ingrese la ruta del archivo a leer: ");
            ruta = Console.ReadLine();
            System.IO.StreamReader archivo;
            try
            {
                archivo = new System.IO.StreamReader(ruta);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    cont++;
                }
                archivo.Close();
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Usted no ha ingresado la ruta");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio no existe");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Lo siento, el archivo no fue econtrado.");
            }
            Console.ReadLine();
        }
    }
}