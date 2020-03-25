using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Son las 5 menos 5 faltan 5 para las 5 cuantas veces dije 5 sin contar el primer 5";
            string[] arr = str.Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);  
                }
            }

            Console.WriteLine();
            ImprimirVector(dict);

            Console.WriteLine("\nSize: \t"+dict.Keys.Count);
            Console.ReadLine();


        }

        public static void ImprimirVector(Dictionary<string, int> dict)
        {
            Console.WriteLine("Key" + "\t\t\t Value \n");
            foreach (var value in dict)
            {
                Console.WriteLine(value.Key.PadRight(10) + "\t\t   " + value.Value);
            }

        }
    }
}
