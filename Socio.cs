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

        /*Metodo Agregar Reserva*/
        public void agregarReserva(Cancha c, DateTime fechaReserva) {
            int posicion = buscarPosicionReserva();
            reservas[posicion] = new Reserva(fechaReserva, c);
        }

        public int buscarPosicionReserva() {
            int posicion = 0;
            while (posicion < reservas.Length && reservas[posicion] != null) {
                posicion++;
            }
            return posicion;
        }

        /*Metodo que lista las reservas de un determinado Socio*/
        public string buscarReservas() {
            string reservasSocio = "";
            int i = 0;
            while (i < reservas.Length && reservas[i] != null) {
                reservasSocio += reservas[i];
                i++;
            }
            return reservasSocio;
        }
    }
}
