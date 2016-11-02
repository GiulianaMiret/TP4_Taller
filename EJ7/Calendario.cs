using System;
using System.Collections.Generic;
namespace EJ7
{
	public class Calendario
	{
		private string iTitulo;
		private DateTime iFechaHoraCreacion;
		private List<Evento> iEventos;

		public Calendario(string pTitulo, DateTime pFechaHoraCreacion)
		{
			this.iTitulo = pTitulo;
			this.iFechaHoraCreacion = pFechaHoraCreacion;
			this.iEventos = new List<Evento>();
		}

		public string Titulo
		{
			get { return this.iTitulo; }
		}

		public DateTime FechaHoraCreacion
		{
			get { return this.iFechaHoraCreacion; }
		}

		public void AgregarEvento(Evento pEvento)
		{
			this.iEventos.Add(pEvento);
		}

		public List<Evento> ObtenerEventos(DateTime pDia)
		{
			var retorno = new List<Evento>();
			this.iEventos.ForEach((Evento evento) =>
			{
				if (evento.Ocurre(pDia))
				{
					retorno.Add(evento);
				}
			});
			return retorno;
		}

		public List<Evento> ObtenerEventos(DateTime pDiaDesde, DateTime pDiaHasta)
		{
			var retorno = new List<Evento>();
			this.iEventos.ForEach((Evento evento) =>
			{
				if (evento.Ocurre(pDiaDesde, pDiaHasta))
				{
					retorno.Add(evento);
				}
			});
			return retorno;
		}
	}
}
