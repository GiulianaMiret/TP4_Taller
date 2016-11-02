using System;

namespace EJ7
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var prueba = new Calendario("2016", new DateTime(2016, 01, 01));
			var evento = new Evento("Fin de Cursada", new DateTime(2016, 11, 18), new TimeSpan(0, 0, 30), Frecuencia.UNA_VEZ_AÑO);
			prueba.AgregarEvento(evento);

			var algo = prueba.ObtenerEventos(new DateTime(2016, 01, 01), new DateTime(2016, 12, 31));
			algo.ForEach((Evento obj) => Console.WriteLine(obj.Titulo));
		}
	}
}
