using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Cancha
    {
        private int codigo;
        private string description;
        private string ubicacion;

        public int Codigo
        {
            get { return codigo; }
        }

        public override string ToString()
        {
            return this.codigo + this.description + this.ubicacion;
        }

        public Cancha(int codigo, string description, string ubicacion)
        {
            this.codigo = codigo;
            this.description = description;
            this.ubicacion = ubicacion;
        }
    }
}
