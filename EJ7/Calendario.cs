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
		}

		public void AgregarEvento(Evento pEvento)
		{
			iEventos.Add(pEvento);
		}

		public List<Evento> ObtenerEventos(DateTime pDia)
		{
			List<Evento> retorno = new List<Evento>();
			iEventos.ForEach((Evento evento) =>
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
			List<Evento> retorno = new List<Evento>();
			iEventos.ForEach((Evento evento) =>
			{
				if (evento.Ocurre(pDiaDesde, pDiaHasta))
				{
					retorno.Add(evento);
				}
			});
			return retorno;
		}


}
