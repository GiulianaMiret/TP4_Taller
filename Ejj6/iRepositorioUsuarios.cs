using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public interface IRepositorioUsuarios
    {
        void Agregar(Usuario pUsuario);

        void Actualizar(Usuario pUsuario);

        void Eliminar(string pCodigo);

        List<Usuario> ObtenerTodos();

        Usuario ObtenerPorCodigo(string pCodigo);

        List<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
    }
}
