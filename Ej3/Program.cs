using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        //Lee un archivo y lo muestra en pantalla
        //pidiendo la ruta del mismo

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
            catch (System.ArgumentException) //Si la ruta es nula, no se le pasa ruta
            {
                Console.WriteLine("Usted no ha ingresado la ruta");
            }
            catch (System.IO.DirectoryNotFoundException) //El directorio no esta, o no es econtrado
            {
                Console.WriteLine("El directorio no existe");
            }
            catch (System.IO.FileNotFoundException) //El archivo no es encontrado
            {
                Console.WriteLine("Lo siento, el archivo no fue econtrado.");
            }
            Console.ReadLine();

            //Falta la Excepcion para cuando la ruta esta mal escrita, es decir
            //en vez de escribir: c:\...
            //se escriba: asdf
        }
    }
}