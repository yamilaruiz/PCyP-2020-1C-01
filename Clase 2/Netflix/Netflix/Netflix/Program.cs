using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace netflix
{
    class Program
    {
        static void Main(string[] args)
        {



            string infile = @"c:\ratings.txt";


            Dictionary<int, int> ReviewsByUser = new Dictionary<int, int>();

            foreach (string line in File.ReadLines(infile))
            {

                int userid = parse(line);

                if (!ReviewsByUser.ContainsKey(userid))
                    ReviewsByUser.Add(userid, 1);
                else
                    ReviewsByUser[userid]++;
            }


            var top10 = ReviewsByUser.OrderByDescending(x => x.Value).Take(10);

            Console.WriteLine();
            Console.WriteLine("TOP 10 PUNTAJES DE USUARIOS:");

            foreach (var user in top10)
            {
                Console.WriteLine("{0}: {1}", user.Key, user.Value);
            }
            Console.ReadLine();


        }
        static int parse(string line)
        {
            char[] separators = { ',' };

            string[] tokens = line.Split(separators);

            int movieid = Convert.ToInt32(tokens[0]);
            int userid = Convert.ToInt32(tokens[1]);
            int rating = Convert.ToInt32(tokens[2]);
            DateTime date = Convert.ToDateTime(tokens[3]);

            return userid;
        }




    }



}