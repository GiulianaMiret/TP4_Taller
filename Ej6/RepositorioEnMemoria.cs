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

        public void Agregar(Usuario pUsuario)
        {
            diccionario.Add(pUsuario.Codigo, pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            diccionario[pUsuario.Codigo] = pUsuario;
        }

       public void Eliminar(string pCodigo)
        {
            diccionario.Remove(pCodigo);
        }

       public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> lista = new List<Usuario>();
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
            PROBLEMILLAS
        }
    }
}
