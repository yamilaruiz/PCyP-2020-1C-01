using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';

            var p1 = Task.Factory.StartNew( () => LeerAbecedario2(letra));
            var p2 = Task.Factory.StartNew( () => LeerAbecedario1(letra));

            Console.ReadLine();
        }
        
        public static void LeerAbecedario1(char letra)
        {
            string tarea2 = null;
            while (letra <= 'z')
            {
                if ((letra % 2) == 0)
                {
                    tarea2 = tarea2 + " "+ letra;

                }
                letra++;
            }
            Console.WriteLine(tarea2);

        }

        public static void LeerAbecedario2(char letra)
        {
            string tarea2 = null;
            while (letra <= 'z')
            {
                if ((letra % 2) != 0)
                {
                    tarea2 = tarea2 + " " + letra;

                }
                letra++;
            }
            Console.WriteLine(tarea2);

        }

    }
}