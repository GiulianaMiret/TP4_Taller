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
			if (pTitulo == string.Empty) throw new ArgumentException("El calendario tiene que tener un titulo. ");
			if (pFechaHoraCreacion < DateTime.Now) throw new ArgumentException("El calendario debe tener una fecha de creacion posterior al dia de hoy. ");

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
			List<Evento>.Enumerator enumerator = this.iEventos.GetEnumerator();
			bool existe = false;
			while (!existe && enumerator.MoveNext())
			{
				existe = enumerator.Current.Titulo == pEvento.Titulo;
			}
			if (existe) throw new ArgumentException("No puede haber 2 eventos con el mismo titulo en el calendario. ");
			this.iEventos.Add(pEvento);
		}

		// Elimina un evento por su titulo
		public void EliminarEvento(string pTituloEvento)
		{
			List<Evento>.Enumerator enumerator = this.iEventos.GetEnumerator();
			bool existe = false;
			while (!existe && enumerator.MoveNext())
			{
				existe = enumerator.Current.Titulo == pTituloEvento;
			}
			if (!existe) throw new Exception("No existe ningun evento con ese nombre. ");
			this.iEventos.Remove(enumerator.Current);
		}

		public List<Evento> ObtenerEventos(DateTime pDia)
		{
			var retorno = new List<Evento>();
			this.iEventos.ForEach((Evento evento) =>
			{
				Tuple<bool, DateTime> tupla = evento.Ocurre(pDia); 
				if (tupla.Item1)
				{
					Evento devuelto = new Evento(evento.Titulo, tupla.Item2, evento.Duracion, evento.FrecuenciaRepeticion);
					retorno.Add(devuelto);
				}
			});
			return retorno;
		}

		public List<Evento> ObtenerEventos(DateTime pDiaDesde, DateTime pDiaHasta)
		{
			var retorno = new List<Evento>();
			this.iEventos.ForEach((Evento evento) =>
			{
				Tuple<bool, DateTime> tupla = evento.Ocurre(pDiaDesde, pDiaHasta);
				if (tupla.Item1)
				{
					Evento devuelto = new Evento(evento.Titulo, tupla.Item2, evento.Duracion, evento.FrecuenciaRepeticion);
					retorno.Add(devuelto);
				}
			});
			return retorno;
		}
	}
}
