using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Cuadrado:FigurasGeométricas
    {
        private int lado1;

        public Cuadrado()
        {
        }

        public Cuadrado(int lado1)
        {
            this.lado1 = lado1;
        }

        public int Lado1
        {
            get
            {
                return lado1;
            }

            set
            {
                lado1 = value;
            }
        }

        public override float Area()
        {
            return lado1 * lado1;
        }

        public override float Perimetro()
        {
            return lado1 * 4;
        }
    }
}
