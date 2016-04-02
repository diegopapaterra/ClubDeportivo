using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Socio
    {
        private int nroSocio;
        private string nombre;
        private string apellido;
        private Reserva[] reservas = new Reserva[10];

        public int NroSocio {
            get{ return nroSocio; }
        }

        public override string ToString()
        {
            return this.nroSocio + this.nombre + this.apellido;
        }

        public Socio(int nroSocio, string nombre, string apellido) {
            this.nroSocio = nroSocio;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
