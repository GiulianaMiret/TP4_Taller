using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Tests
{
    [TestClass()]
    public class CalendarioTests
    {
       
        [TestMethod()]
        public void AgregarEventoTest()
        {
            Calendario calendario = new Calendario("Taller", DateTime.Today);

            Evento evento = new Evento("Entrega Trabajo", new DateTime(2016, 02, 02), TimeSpan.FromDays(2), Frecuencia.UNICA_VEZ);

            calendario.AgregarEvento(evento);

            List<Evento> lista = new List<Evento>();
            lista.Add(evento);

            //Assert.IsNull(calendario.ObtenerEventos(new DateTime(2016,02,02)));
            Assert.ReferenceEquals(lista, calendario.ObtenerEventos(new DateTime(2016, 02, 02)));
        }

        [TestMethod()]
        public void ObtenerEventosTest()
        {
            Calendario calendario = new Calendario("Taller", DateTime.Today);

            Evento evento = new Evento("Trabajo Final", DateTime.Today, TimeSpan.FromDays(2), Frecuencia.UNICA_VEZ);

            calendario.AgregarEvento(evento);
            calendario.AgregarEvento(new Evento("TP", DateTime.Today.AddDays(3), TimeSpan.FromDays(1), Frecuencia.UNA_VEZ_SEMANA));
            calendario.AgregarEvento(new Evento("Parcial", new DateTime(2016, 02, 12), TimeSpan.FromDays(5), Frecuencia.UNA_VEZ_AÑO));
            
            Assert.AreEqual(evento, calendario.ObtenerEventos(DateTime.Today));
        }

        [TestMethod()]
        public void ObtenerEventosTest1()
        {
            Calendario calendario = new Calendario("Taller", DateTime.Today);

            Evento evento = new Evento("Trabajo Final", DateTime.Today, TimeSpan.FromDays(2), Frecuencia.UNICA_VEZ);

            calendario.AgregarEvento(evento);
            calendario.AgregarEvento(new Evento("TP", DateTime.Today, TimeSpan.FromDays(1), Frecuencia.UNA_VEZ_SEMANA));
            calendario.AgregarEvento(new Evento("Parcial", new DateTime(2016, 02, 12), TimeSpan.FromDays(5), Frecuencia.UNA_VEZ_AÑO));
            List<Evento> lista = new List<Evento>();
            lista.Add(evento);
            lista.Add(new Evento("TP", DateTime.Today.AddDays(5), TimeSpan.FromDays(1), Frecuencia.UNA_VEZ_SEMANA));

            lista.Add(new Evento("Parcial", DateTime.Today.AddDays(1), TimeSpan.FromDays(5), Frecuencia.UNA_VEZ_AÑO));

            Assert.AreEqual(lista, calendario.ObtenerEventos(DateTime.Today, DateTime.Today.AddDays(2)));
        }
    }
}