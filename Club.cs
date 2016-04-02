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

                Familiar p = new Familiar(nroSocio, nombre, apellido, cantIntegrantes);
                int posicion = buscarPosicion();
                socios[posicion] = p;
                resultado = true;
            }
            return resultado;
        }

        /*Buscar Posicion del Array para saber donde guardo*/
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
    }
}
