using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class RepositorioEnMemoria : IRepositorioUsuarios
    {
        public List<Usuario> lista = new List<Usuario>();
        //public List<KeyValuePair<string, Usuario>> lista = new List<KeyValuePair<string, Usuario>>();
        //Agrega un Usuario al diccionario
        public void Agregar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }
            if (!lista.Contains(pUsuario))
            {
                lista.Add(pUsuario);
            }
        }

        //Actualiza un Usuario del diccionario, buscandolo por el Codigo (clave)
        public void Actualizar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

            if (!lista.Contains(pUsuario))
            {
                //throw new KeyNotFoundException(nameof(pUsuario));
                throw new Exception(nameof(pUsuario));
            }
            var aux = lista.FirstOrDefault(x  => x.Codigo == pUsuario.Codigo);
            lista.Remove(aux);
            lista.Add(pUsuario);
        }

        //Elimina a un Usuario especifico buscandolo por el codigo
        public void Eliminar(string pCodigo)
        {
            if (pCodigo == null)
            {
                throw new ArgumentNullException(nameof(pCodigo));
            }

            var aux = lista.FirstOrDefault(x => x.Codigo == pCodigo);

            if (!lista.Contains(aux))
            {
                throw new Exception(nameof(pCodigo));
            }
            
            lista.Remove(aux);
        }

        //Obtiene todos los usuarios que estan en el diccionario
        //pasandolos a una lista, sin ningun orden especifico
        public List<Usuario> ObtenerTodos()
        {
            if (lista == null)
            {
                throw new ArgumentNullException(nameof(lista));
            }

            return lista;
        }

        //Obtiene a un solo Usuario
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            if (lista == null)
            {
                throw new ArgumentNullException(nameof(lista));
            }
            var aux = lista.FirstOrDefault(x => x.Codigo == pCodigo);
            return aux;
        }


        //Obtiene los usuarios ordenados por un determinado criterio.
        //Si se pasa null como criterio, utiliza el ordenamiento por defecto
        //que es ordenarlo alfabeticamente por Codigo

        //los otros orenamientos posibles son:
        //Segun el Correo Electronico
        //Segun el Nombre
        //Segun el Nombre y el Codigo
        public List<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            //List<Usuario> usuarios = new List<Usuario>(this.lista.Values);

            //usuarios.Sort(pComparador);

            //return usuarios;

            if (lista == null)
            {
                throw new ArgumentNullException(nameof(lista));
            }

            lista.Sort(pComparador);

            return lista;
        }

        public List<Usuario> BuscarPorAproximacion(string pNombreCompleto)
        {
            List<Usuario> listaAux = lista.FindAll(x => x.NombreCompleto.IndexOf(pNombreCompleto, StringComparison.OrdinalIgnoreCase) != -1);
            return listaAux;
        }
    }
}
