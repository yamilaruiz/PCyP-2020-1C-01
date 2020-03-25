using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            List<string> removeColors = new List<string> { "RED", "WHITE", "BLUE" };

            ImprimirVector(colors);

            for(int i = 0; i < colors.Count; i++)
            {
                for (int y = 0; y < removeColors.Count; y++)
                {
                    if (colors[i].Equals(removeColors[y]))
                    {
                        colors.RemoveAt(i);
                    }
                }
            }
            Console.WriteLine("\nColors list after remove items\n");
            ImprimirVector(colors);

            Console.ReadLine();
        }
        
        public static void ImprimirVector(List<string> vector)
        {
            foreach(var i in vector) //(int i = 0; i< vector.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
