using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class RepositorioEnMemoria: IRepositorioUsuarios
    {
        public SortedDictionary<string, Usuario> diccionario = new SortedDictionary<string, Usuario>();

        //Agrega un Usuario al diccionario
        public void Agregar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

            diccionario.Add(pUsuario.Codigo, pUsuario);
        }

        //Actualiza un Usuario del diccionario, buscandolo por el Codigo (clave)
        public void Actualizar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

            if (!diccionario.ContainsKey(pUsuario.Codigo))
            {
                throw new KeyNotFoundException(nameof(pUsuario));
            }

            diccionario[pUsuario.Codigo] = pUsuario;
            
        }
       
        //Elimina a un Usuario especifico buscandolo por el codigo
       public void Eliminar(string pCodigo)
        {
            if (pCodigo == null)
            {
                throw new ArgumentNullException(nameof(pCodigo));
            }

            if (!diccionario.ContainsKey(pCodigo))
            {
                throw new KeyNotFoundException(nameof(pCodigo));
            }

            diccionario.Remove(pCodigo);
        }

        //Obtiene todos los usuarios que estan en el diccionario
        //pasandolos a una lista, sin ningun orden especifico
       public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> lista = new List<Usuario>();
            if (lista == null)
            {
                throw new ArgumentNullException(nameof(lista));
            }
            foreach (KeyValuePair<string, Usuario> result in diccionario)
            {
                lista.Add(result.Value);
            }

            return lista;
        }

        //Obtiene a un solo Usuario
       public Usuario ObtenerPorCodigo(string pCodigo)
        {
            
            return diccionario[pCodigo];
        }


        //Obtiene los usuarios ordenados por un determinado criterio.
        //Si se pasa null como criterio, utiliza el ordenamiento por defecto
        //que es ordenarlo alfabeticamente por Codigo

        //los otros orenamientos posibles son:
                //Segun el Correo Electronico
                //Segun el Nombre
                //Segun el Nombre y el Codigo
       public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> usuarios = new List<Usuario>(this.diccionario.Values);

            usuarios.Sort(pComparador);

            return usuarios;
        }

        
    }
}
