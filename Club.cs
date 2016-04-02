using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Club
    {
        private Socio[] socios = new Socio[10];
        private Cancha[] canchas = new Cancha[10];

        /*Metodo Alta Particular*/
        public bool altaParticular(int nroSocio, string nombre, string apellido, DateTime fechaAntiguedad) {
            bool resultado = false;
            Socio s = buscarSocio(nroSocio);
            if (s == null) {

                Particular p = new Particular(nroSocio, nombre, apellido, fechaAntiguedad);
                int posicion = buscarPosicion();
                socios[posicion] = p;
                resultado = true;
            }
            return resultado;
        }

        /*Metodo Alta Familiar*/
        public bool altaFamiliar(int nroSocio, string nombre, string apellido, int cantIntegrantes)
        {
            bool resultado = false;
            Socio s = buscarSocio(nroSocio);
            if (s == null)
            {

                Familiar f = new Familiar(nroSocio, nombre, apellido, cantIntegrantes);
                int posicion = buscarPosicion();
                socios[posicion] = f;
                resultado = true;
            }
            return resultado;
        }

        /*Metodo Alta Cancha*/
        public bool altaCancha(int codigo, string description, string ubicacion) {
            bool resultado = false;
            Cancha c = buscarCancha(codigo);
            if (c == null)
            {

                Cancha p = new Cancha(codigo, description, ubicacion);
                int posicion = buscarPosicion();
                canchas[posicion] = p;
                resultado = true;
            }
            return resultado;
        }


        /*Buscar Cancha*/
        /*Buscar Posicion del Array para saber donde guardo en Canchas*/
        public int buscarPosicionCancha()
        {
            int posicion = 0;
            while (posicion < canchas.Length && canchas[posicion] != null)
            {
                posicion++;
            }
            return posicion;
        }

        public Cancha buscarCancha(int codigo)
        {
            Cancha c = null;
            int i = 0;
            while (i < canchas.Length && c == null)
            {
                if (canchas[i] != null)
                {
                    if (canchas[i].Codigo == codigo)
                    {
                        c = canchas[i];
                    }
                }
                i++;
            }
            return c;
        }

        /*Termino aca Canchas*/

        /*Buscar Posicion del Array para saber donde guardo Socios*/
        public int buscarPosicion() {
            int posicion = 0;
            while (posicion < socios.Length && socios[posicion] != null) {
                posicion++;
            }
            return posicion;
        }

        public Socio buscarSocio(int nroSocio) {
            Socio s = null;
            int i = 0;
            while(i < socios.Length && s == null){
                if(socios[i] != null){
                    if (socios[i].NroSocio == nroSocio) {
                        s = socios[i];
                    }
                }
                i++;
            }
            return s;
        }

        public string listarSocios() {
            string socio = "";
            for (int i = 0; i < socios.Length; i++) {
                if (socios[i] != null) {
                    socio += socios[i].ToString();
                }
            }
            return socio;
        }

        /*Listar Canchas*/
        public string listarCanchas()
        {
            string cancha = "";
            for (int i = 0; i < canchas.Length; i++)
            {
                if (canchas[i] != null)
                {
                    cancha += canchas[i].ToString();
                }
            }
            return cancha;
        }
    }
}
