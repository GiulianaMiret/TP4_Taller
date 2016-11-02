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

		public bool Ocurre(DateTime pFecha)
		{
			switch (this.FrecuenciaRepeticion)
			{
				case Frecuencia.UNICA_VEZ: 
					{
						return this.FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date;
					}
				case Frecuencia.UNA_VEZ_MES:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddMonths(1);
						}
						return valido;
					}
				case Frecuencia.UNA_VEZ_SEMANA:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddDays(7);
						}
						return valido;
					}
				case Frecuencia.UNA_VEZ_AÑO:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddYears(1);
						}
						return valido;
					}
				default:
					{
						return this.FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date;
					}
			}
		}

		public bool Ocurre(DateTime pFecha, DateTime pFechaHasta)
		{
			switch (this.FrecuenciaRepeticion)
			{
				case Frecuencia.UNICA_VEZ:
					{
						return this.FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date;
					}
				case Frecuencia.UNA_VEZ_MES:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddMonths(1);
						}
						return valido;
					}
				case Frecuencia.UNA_VEZ_SEMANA:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddDays(7);
						}
						return valido;
					}
				case Frecuencia.UNA_VEZ_AÑO:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							if (pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date)
								valido = true;
							fechaComprobacion.AddYears(1);
						}
						return valido;
					}
				default:
					{
						return this.FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date;
					}
			}
		}
	}
}
