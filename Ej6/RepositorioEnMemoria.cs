using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class RepositorioEnMemoria: IRepositorioUsuarios
    {
        //FALTAN COMPROBACIONES Y ESAS COSAS.. TIERAR EXCEPCIONES PARA TODOS LADOS
        public SortedDictionary<string, Usuario> diccionario = new SortedDictionary<string, Usuario>();

        public void Agregar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

            diccionario.Add(pUsuario.Codigo, pUsuario);
        }

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

       public Usuario ObtenerPorCodigo(string pCodigo)
        {
            
            return diccionario[pCodigo];
        }

       public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> usuarios = new List<Usuario>(this.diccionario.Values);

            usuarios.Sort(pComparador);

            return usuarios;
        }

        
    }
}
