using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city;
            string[] population;
            string[] area;
            int max = 0;
            int mostPop = 0;
            decimal density;
            //string input = Console.ReadLine();
            string input = "Kharkiv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352";
            //population = int.Parse(input);
            //Console.WriteLine(population);
            
            city = input.Split(';');

            for (var i = 0; i < city.Length; i++)
            {
                string[] part1 = city[i].Split('=');
                Console.WriteLine(part1[0]);
                int letters = part1[0].Length;
                Console.WriteLine(letters);
                Console.WriteLine();

                if (letters > max)
                    max = letters;
            }
            Console.WriteLine("Longest: " + max);


            population = input.Split('=');
            for (var i = 1; i < population.Length; i++)
            {
                string[] part2 = population[i].Split(',');
                Console.WriteLine(part2[0]);
                Console.WriteLine();
                int pop = int.Parse(part2[0]);

                if (pop > mostPop)
                    mostPop = pop;
            }
            Console.WriteLine("Most populated: " + mostPop);

            area = input.Split(',');

            for (var i = 1; i < area.Length; i++)
            { 
                string[] part3 = area[i].Split(';');
                Console.WriteLine(part3[0]);
                Console.WriteLine();
               // density = int.Parse(part2[0]) / int.Parse(part3[0]);
            }

            /* for (int j=0;  j > input.Length; j++)
                 Console.Write(input[j]);
             Console.WriteLine();*/

            /*  for (int j = 0; j < input.Length; j++)

              {
                  Console.Write(input[j]);
                  if (input[j] == ',')
                      break;
              }
                  Console.WriteLine();
              for (int k = 0; k < input.Length; k++)
              {
                  Console.Write(input[k]);
                  if (input[k] == ';')
                      break;
              }
              Console.WriteLine();*/
        }
    }
}
