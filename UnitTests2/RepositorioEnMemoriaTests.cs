using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Tests
{
    [TestClass()]
    public class RepositorioEnMemoriaTests
    {
        [TestMethod()]
        public void AgregarEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            List<Usuario> lista = new List<Usuario>();

            lista.Add(user);

            Assert.ReferenceEquals(lista, repo.ObtenerTodos());
        }

        [TestMethod()]
        public void ActualizarEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("123", "Auyj", "asdg@asdg.com");

            repo.Actualizar(user2);

            user = repo.ObtenerPorCodigo(user.Codigo);

            Assert.AreEqual(user2, user);
        }

        [TestMethod()]
        public void EliminarEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("456", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            repo.Eliminar(user.Codigo);

            List<Usuario> lista = new List<Usuario>();

            lista.Add(user2);

            Assert.ReferenceEquals(lista, repo.ObtenerTodos());
        }

        [TestMethod()]
        public void ObtenerTodosEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("456", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            List<Usuario> lista = new List<Usuario>();

            lista.Add(user2);
            lista.Add(user);

            Assert.ReferenceEquals(lista, repo.ObtenerTodos());
        }

        [TestMethod()]
        public void ObtenerPorCodigoEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("456", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            Assert.ReferenceEquals(user, repo.ObtenerPorCodigo(user.Codigo));
        }

        [TestMethod()]
        public void ObtenerOrdenadosPorNombreEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("456", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            IList<Usuario> lista = repo.ObtenerOrdenadosPor(new ComparadorNombre());


            Assert.AreEqual("ADG", lista[0].NombreCompleto);
        }

        [TestMethod()]
        public void ObtenerOrdenadosPorCorreoEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gaussegender");

            repo.Agregar(user);

            Usuario user2 = new Usuario("456", "ADG", "asdgasdg");

            repo.Agregar(user2);

            IList<Usuario> lista = repo.ObtenerOrdenadosPor(new ComparadorCorreoElectronico());


            Assert.AreEqual(user, lista[0]);
        }

        [TestMethod()]
        public void ObtenerOrdenadosPorNombreyCodigoEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("123", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("124", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            IList<Usuario> lista = repo.ObtenerOrdenadosPor(new ComparadorNombreyCodigo());

            string esperado = user2.NombreCompleto + user2.Codigo;

            Assert.AreEqual(esperado, lista[0].NombreCompleto + lista[0].Codigo);
        }


        [TestMethod()]
        public void ObtenerOrdenadosPorDefectoEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("423", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("156", "ADG", "asdg@asdg.com");

            repo.Agregar(user2);

            IList<Usuario> lista = repo.ObtenerOrdenadosPor(null);

            Assert.AreEqual(user2, lista[0]);
        }

        [TestMethod()]
        public void BuscarPorAproximacionEj6Test()
        {
            RepositorioEnMemoria repo = new RepositorioEnMemoria();

            Usuario user = new Usuario("423", "Gauss", "gauss@legender.com");

            repo.Agregar(user);

            Usuario user2 = new Usuario("156", "Lolipop", "asdg@asdg.com");

            repo.Agregar(user2);

            IList<Usuario> lista = repo.BuscarPorAproximacion("aus");

            Assert.AreEqual(user, lista[0]);

        }

    }
}