using System;
namespace EJ7
{
	public class Evento
	{
		private string iTitulo;
		private DateTime iFechaHoraComienzo;
		private TimeSpan iDuracion;
		private Frecuencia iFrecuencia;

		public Evento(string pTitulo, DateTime pFechaHoraComienzo, TimeSpan pDuracion, Frecuencia pFrecuencia)
		{
			this.iTitulo = pTitulo;
			this.iFechaHoraComienzo = pFechaHoraComienzo;
			this.iDuracion = pDuracion;
			this.iFrecuencia = pFrecuencia;
		}

		public string Titulo
		{
			get { return this.iTitulo; }
		}

		public Frecuencia FrecuenciaRepeticion {
			get { return this.iFrecuencia; }
		}

		public TimeSpan Duracion
		{
			get { return this.iDuracion; }
		}

		public DateTime FechaHoraComienzo
		{
			get { return this.iFechaHoraComienzo; }
		}
	}
}
