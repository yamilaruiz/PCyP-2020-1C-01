using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conejitos
{
    class Program
    {
        static void Main(string[] args)
        {

           
            List <Task<int>> tasks = new List<Task<int>>();

            int y = 12;
          
            for (int i=0; i< 4; i++)
            {
                
                tasks.Add(Task.Factory.StartNew<int>(() => Fibonacci(y)));
                Thread.Sleep(1000);
                y++;
            };

            while (tasks.Count > 0){

                int index = Task.WaitAny(tasks.ToArray());
                Console.WriteLine("Resultado: "+ tasks[index].Result);

                tasks.RemoveAt(index);
            }
            

            Console.ReadLine();
        }



        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
