using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Familiar:Socio
    {
        private int cantIntegrantes;

        public override string ToString()
        {
            return base.ToString() + this.cantIntegrantes;
        }

        public Familiar(int nroSocio, string nombre, string apellido, int cantIntegrantes) :base(nroSocio, nombre, apellido) {
            this.cantIntegrantes = cantIntegrantes;
        }
    }
}
