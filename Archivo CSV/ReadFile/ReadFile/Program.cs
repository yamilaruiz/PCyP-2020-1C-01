using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("C:/vial.csv");

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                ArchivoCsv iteam = new ArchivoCsv(valores[0], valores[1], valores[2], valores[3], valores[4]);
                iteam.imprimir();
                Console.ReadLine();
              
            }
        }
    }
}
