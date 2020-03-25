using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string valor = null; 

            dict.Add("Juan", "55423412");
            dict.Add("Ernesto", "56985623");
            dict.Add("Mariana", "54787451");

            Console.WriteLine("Finding Juan.. ");
            if (dict.ContainsKey("Juan"))
            { 
                Console.WriteLine("The key 'Juan' exist, this contains the value: " + dict["Juan"]);
            }
            else
            { 
                Console.WriteLine("The key 'Juan' don't exist");
            }

            Console.WriteLine("\n Finding Pedro.. ");
            if (dict.TryGetValue("Pedro", out valor))
            {
                Console.WriteLine("The key 'Pedro' exist, this contain the value: " + valor);
            }
            else
            {
                Console.WriteLine("Does not contain the key 'Pedro'");
            }

            Console.WriteLine("\nShowing all the keys-values");
            foreach (var value in dict)
            {
                Console.WriteLine("\n\t Key: " + value.Key + "\t with value:"+ value.Value);
            }

            Console.WriteLine("\n Updating Mariana.. ");
            if (dict.TryGetValue("Mariana", out valor))
            {
                dict["Mariana"] = "58251425";
                Console.WriteLine("New value for the key 'Mariana': " + dict["Mariana"]);
            }
            else
            {
                Console.WriteLine("Does not contain the key 'Pedro'");
            }

            Console.ReadLine();
              
        }
    }
}
