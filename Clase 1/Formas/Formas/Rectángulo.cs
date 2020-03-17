using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Rectángulo:FigurasGeométricas
    {
        private int lado1;
        private int lado2;

        public Rectángulo()
        {
        }

        public Rectángulo(int lado1, int lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
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

        public int Lado2
        {
            get
            {
                return lado2;
            }

            set
            {
                lado2 = value;
            }
        }

        public override float Area()
        {
            return lado1 * lado2;
        }

        public override float Perimetro()
        {
            return lado1 * 2 + lado2 * 2;
        }
    }
}
