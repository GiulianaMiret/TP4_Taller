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
			if (pTitulo == string.Empty) throw new ArgumentException("El titulo del evento debe ser distinto a la cadena vacia.");
			if (pFechaHoraComienzo.ToBinary() <= DateTime.Now.ToBinary()) throw new ArgumentException("La fecha/hora de comienzo deben ser posteriores al dia de hoy"); 
			if (pDuracion.Minutes < 5) throw new ArgumentException("La duracion debe ser de por lo menos 5 minutos.");

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

		public Tuple<bool, DateTime> Ocurre(DateTime pFecha)
		{
			switch (this.FrecuenciaRepeticion)
			{
				case Frecuencia.UNICA_VEZ: 
					{
						return Tuple.Create(FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date,
						                    this.FechaHoraComienzo);
					}
				case Frecuencia.UNA_VEZ_MES:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							valido = pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date;
							if(!valido)
								fechaComprobacion.AddMonths(1);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				case Frecuencia.UNA_VEZ_SEMANA:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							valido = pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date;
							if (!valido)
								fechaComprobacion.AddDays(7);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				case Frecuencia.UNA_VEZ_AÑO:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && pFecha.Date >= fechaComprobacion.Date)
						{
							valido = pFecha.Date == fechaComprobacion.Date || fechaComprobacion.Add(this.Duracion).Date == pFecha.Date;
							if(!valido)
								fechaComprobacion.AddYears(1);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				default:
					{
						return Tuple.Create(FechaHoraComienzo.Date == pFecha.Date || this.FechaHoraComienzo.Add(this.Duracion).Date == pFecha.Date,
											this.FechaHoraComienzo);
					}
			}
		}

		public Tuple<bool, DateTime> Ocurre(DateTime pFecha, DateTime pFechaHasta)
		{
			switch (this.FrecuenciaRepeticion)
			{
				case Frecuencia.UNICA_VEZ:
					{
						return Tuple.Create(this.FechaHoraComienzo.Date >= pFecha.Date && this.FechaHoraComienzo.Date <= pFechaHasta.Date,
											this.FechaHoraComienzo);
					}
				case Frecuencia.UNA_VEZ_MES:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && fechaComprobacion.Date <= pFechaHasta.Date)
						{
							valido = pFecha.Date <= fechaComprobacion.Date;
							if(!valido) fechaComprobacion.AddMonths(1);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				case Frecuencia.UNA_VEZ_SEMANA:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && fechaComprobacion.Date <= pFechaHasta.Date)
						{
							valido = pFecha.Date <= fechaComprobacion.Date;
							if(!valido) fechaComprobacion.AddDays(7);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				case Frecuencia.UNA_VEZ_AÑO:
					{
						DateTime fechaComprobacion = this.FechaHoraComienzo;
						bool valido = false;
						while (valido == false && fechaComprobacion.Date <= pFechaHasta.Date)
						{
							valido = pFecha.Date <= fechaComprobacion.Date;
							if(!valido) fechaComprobacion.AddYears(1);
						}
						return Tuple.Create(valido, fechaComprobacion);
					}
				default:
					{
						return Tuple.Create(this.FechaHoraComienzo.Date >= pFecha.Date && this.FechaHoraComienzo.Date <= pFechaHasta.Date, 
						                    this.FechaHoraComienzo);
					}
			}
		}
	}
}
