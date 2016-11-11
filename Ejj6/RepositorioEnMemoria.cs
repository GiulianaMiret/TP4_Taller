using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
     class RepositorioEnMemoria : IRepositorioUsuarios
    {
        public List< Usuario> lista = new List<Usuario>();

        //Agrega un Usuario al diccionario
        public void Agregar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

           lista.Add(pUsuario);
        }

        //Actualiza un Usuario del diccionario, buscandolo por el Codigo (clave)
        public void Actualizar(Usuario pUsuario)
        {
            if (pUsuario == null)
            {
                throw new ArgumentNullException(nameof(pUsuario));
            }

           //  if (!lista.Contains(pUsuario.Codigo))
           // {
               // throw new KeyNotFoundException(nameof(pUsuario));
           // }

          Usuario usuario =lista.Find(xUsuario => xUsuario.Codigo == pUsuario.Codigo);
            

        }

        //Elimina a un Usuario especifico buscandolo por el codigo
        public void Eliminar(string pCodigo)
        {
            Usuario usuario = lista.Find(xUsuario => xUsuario.Codigo == pCodigo);
            if (lista.Contains(usuario))
            {
                lista.Remove(usuario);
            }
            else
            {
                throw new ArgumentNullException(nameof(pCodigo));
            }
            
            
        }

        //Obtiene todos los usuarios que estan en el diccionario
        //pasandolos a una lista, sin ningun orden especifico
        public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> lista1 = new List<Usuario>();
            if (lista == null)
            {
                throw new ArgumentNullException(nameof(lista));
            }
            foreach (KeyValuePair<string, Usuario> result in lista)
            {
                lista1.Add(result.Value);
            }

            return lista;
        }

        //Obtiene a un solo Usuario
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario usuario = lista.Find(xUsuario => xUsuario.Codigo == pCodigo);
            return usuario;
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
            List<Usuario> usuarios = new List<Usuario>(this.lista);

            usuarios.Sort(pComparador);

            return usuarios;
        }

    {
    }
}
