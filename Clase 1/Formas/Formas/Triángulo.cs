using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Triángulo : FigurasGeométricas
    {
        private int lado1;
        private int lado2;
        private int lado3;
        private int bse;
        private int altura;

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

        public int Lado3
        {
            get
            {
                return lado3;
            }

            set
            {
                lado3 = value;
            }
        }

        public int Bse
        {
            get
            {
                return bse;
            }

            set
            {
                bse = value;
            }
        }

        public int Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public Triángulo(int lado1, int lado2, int lado3, int bse, int altura)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.bse = bse;
            this.altura = altura;
        }

        public Triángulo()
        {
        }



        public override float Area()
        {
            return (bse * altura) / 2;
        }

        public override float Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
