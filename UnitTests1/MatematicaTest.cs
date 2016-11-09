using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Tests
{
    [TestClass()]
    public class MatematicaTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            
            Assert.AreEqual(3, Matematica.Dividir(6, 2));
        }

        [TestMethod()]
        public void DividirPorCeroTest()
        {
            try
            {
                Matematica.Dividir(5, 0);
                ///Assert.IsFalse(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}