using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Reserva
    {
        private Cancha cancha;
        private DateTime fecha;

        public Cancha Cancha {
            get { return cancha; }
        }
        public Reserva(DateTime fechaReserva, Cancha cancha) {
            this.fecha = fechaReserva;
            this.cancha = cancha;
        }

        public override string ToString()
        {
            return "La cancha reservada es "+this.cancha.ToString()+" la fecha de la reserva es: "+this.fecha;
        }
    }
}
