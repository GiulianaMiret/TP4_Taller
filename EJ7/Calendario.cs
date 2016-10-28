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
			IEnumerator<Evento> enumerador = iEventos.GetEnumerator();
			bool valido = true;
			while (valido && enumerador.MoveNext())
			{
				if(enumerador.Current.FechaHoraComienzo <= pEvento.FechaHoraComienzo && enumerador.Current.FechaHoraComienzo.Add(enumerador.Current.Duracion) > enumerador.Current.FechaHoraComienzo)
					valido = false;
				if (enumerador.Current.FechaHoraComienzo >= pEvento.FechaHoraComienzo && pEvento.FechaHoraComienzo.Add(pEvento.Duracion) > enumerador.Current.FechaHoraComienzo)
					valido = false;
			}
			if(valido == false)
				
			iEventos.Add(pEvento);
		}

		public List<Evento> ObtenerEventos(DateTime pDia)
		{
			List<Evento> retorno = new List<Evento>();
			iEventos.ForEach((Evento evento) =>
			{
				if (evento.FechaHoraComienzo.Date == pDia.Date)
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
				if (evento.FechaHoraComienzo.Date > pDiaDesde.Date && evento.FechaHoraComienzo < pDiaHasta.Date)
				{
					retorno.Add(evento);
				}
			});
			return retorno;
		}


}
