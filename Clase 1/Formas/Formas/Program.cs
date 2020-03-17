using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
           
            int a, b, c, d, e;
            
            while (flag != -1)
            {
                Console.Write("Elegir: \n 1-Triángulo \n 2-Rectángulo \n 3-Cuadrado \n (-1)-Salir \n");
                flag = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar valores de lados: ");
                switch (flag)
                {
                    case 1:
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar base y altura : ");
                        d = int.Parse(Console.ReadLine());
                        e = int.Parse(Console.ReadLine());

                        Triángulo triangulo = new Triángulo(a, b, c, d, e);

                        Console.WriteLine("Área: " + triangulo.Area() + " Perímetro: " + triangulo.Perimetro());
                        break;

                    case 2:
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());

                        Rectángulo rectangulo = new Rectángulo(a, b);
                        Console.WriteLine("Área: " + rectangulo.Area() + " Perímetro: " + rectangulo.Perimetro());
                        break;

                    case 3:
                        a = int.Parse(Console.ReadLine());
                        Cuadrado cuadrado = new Cuadrado(a);
                        Console.WriteLine("Área: " + cuadrado.Area() + " Perímetro: " + cuadrado.Perimetro());
                        break;
                }
            }
            
        }
    }
}
