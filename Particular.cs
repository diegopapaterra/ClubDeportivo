using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Particular:Socio
    {
        private DateTime fechaAntiguedad;

        public override string ToString()
        {
            return base.ToString() + this.fechaAntiguedad;
        }

        public Particular(int nroSocio, string nombre, string apellido, DateTime fechaAntiguedad):base(nroSocio, nombre, apellido) {
            this.fechaAntiguedad = fechaAntiguedad;
        }
    }
}
