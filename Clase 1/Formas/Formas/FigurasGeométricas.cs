using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    abstract class FigurasGeométricas
    {
        private int lado;

        public FigurasGeométricas()
        {
        }

        protected FigurasGeométricas(int lado)
        {
            this.lado = lado;
        }

        public int Lado
        {
            get
            {
                return lado;
            }

            set
            {
                lado = value;
            }
        }

        public abstract float Area();
        public abstract float Perimetro();

    }
}
