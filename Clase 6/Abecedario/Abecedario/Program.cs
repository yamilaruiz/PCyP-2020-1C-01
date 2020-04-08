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

    /*class Program
    {

        static void Main(string[] args)
        {

                char letra = 'a';
                Thread p1;
                p1 = new Thread(LeerAbecedario);
                p1.Start();


            while (letra <= 'z')
            {
                if ((letra % 2) == 0)
                {
                    Console.WriteLine(letra + " 1");
                }
                letra++;
                Thread.Sleep(11);
            }
                Console.ReadKey();

         }

            public static void LeerAbecedario()
            {
                char letra = 'a';

                while (letra <= 'z')
                {

                    if ((letra % 2) != 0) {
                       Console.WriteLine(letra + " 2");
                    }

                    letra++;
                    Thread.Sleep(10);
                }


            }

	}*/
}
 