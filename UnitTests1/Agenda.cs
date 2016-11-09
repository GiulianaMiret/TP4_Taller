using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests1
{
    [TestClass]
    public class Agenda
    {
        [TestMethod]
        public void AgregarEventoTest()
        {
            Evento evento1 = new Evento("Evento uno", new DateTime(2016, 11, 09, 20, 0, 0), new TimeSpan(1, 20, 00), Frecuencia.UNA_VEZ_SEMANA);
            Calendario calendario = new Calendario("Calendario", new DateTime(2016, 10, 01));
            calendario.AgregarEvento(evento1);
            List<Evento> listaEsperada = new List<Evento>();
            listaEsperada.Add(evento1);
            Assert.ReferenceEquals(listaEsperada, calendario.ObtenerEventos(new DateTime(2016, 11, 09)));
        }

        [TestMethod]
        public  void EliminarEventoTest()
        {
            Evento evento1 = new Evento("Evento uno", new DateTime(2016, 11, 07), new TimeSpan(1, 20, 00), Frecuencia.UNA_VEZ_SEMANA);
            Evento evento2 = new Evento("Evento dos", new DateTime(2016, 11, 09), new TimeSpan(0, 30, 00), Frecuencia.UNICA_VEZ);
            Calendario calendario = new Calendario("Calendario", new DateTime(2016, 10, 01));
            calendario.AgregarEvento(evento1);
            calendario.AgregarEvento(evento2);
            List<Evento> listaEsperada = new List<Evento>();
            listaEsperada.Add(evento1);
            calendario.EliminarEvento("Evento dos");
            Assert.ReferenceEquals(listaEsperada, calendario.ObtenerEventos(new DateTime(2016, 10, 01), DateTime.Today));
        }

        [TestMethod]
        public void ObtenerEventosTest()
        {
            Evento evento1 = new Evento("Evento uno", new DateTime(2016, 11, 07), new TimeSpan(1, 20, 00), Frecuencia.UNA_VEZ_SEMANA);
            Calendario calendario = new Calendario("Calendario", new DateTime(2016, 10, 01));
            calendario.AgregarEvento(evento1);
            List<Evento> listaEsperada = new List<Evento>();
            listaEsperada.Add(evento1);
            Assert.ReferenceEquals(listaEsperada, calendario.ObtenerEventos(new DateTime(2016, 11, 07)));
        }

        [TestMethod]
        public void ObtenerEventos2Test()
        {
            Evento evento1 = new Evento("Evento uno", new DateTime(2016, 11, 07), new TimeSpan(1, 20, 00), Frecuencia.UNA_VEZ_SEMANA);
            Calendario calendario = new Calendario("Calendario", new DateTime(2016, 10, 01));
            calendario.AgregarEvento(evento1);
            Evento evento2 = new Evento("Evento dos", new DateTime(2016, 11, 02), new TimeSpan(0, 30, 00), Frecuencia.UNICA_VEZ);
            calendario.AgregarEvento(evento2);
            List<Evento> listaEsperada = new List<Evento>();
            listaEsperada.Add(evento1);
            Assert.ReferenceEquals(listaEsperada, calendario.ObtenerEventos(new DateTime(2016, 11, 01), new DateTime(2016,11,03)));
        }
    }
}
