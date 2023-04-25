using _2._6_Barn_Klasse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Barn_Klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Models.Barn> børn = new List<Models.Barn>();

            // Loop to add bject to the list
            for (int i = 1; i < 5; i++)
            {
                børn.Add(new Models.Barn(i, "Henrik d. " + i, "Hansen", + i * 20));
            }

            var børnOver30kg = børn.Where(x => x.Vægt > 30).ToList();
            Console.WriteLine("Børn over 30 kg");
            foreach (var barn in børnOver30kg)
            {
                Console.WriteLine("Navn: " + barn.Navn + "Vægt: " + barn.Vægt + "kg");
            }

            Console.WriteLine("gennemsnitsvægt af all børn: " + børn.Average(x => x.Vægt));

            // Calls method
            var børnOver40kg = Find(børn, 40);
            Console.WriteLine("Børn over 40 kg");
            foreach (var barn in børnOver40kg)
            {
                Console.WriteLine("Navn: " + barn.Navn + "Vægt: " + barn.Vægt + "kg");
            }

            Console.ReadLine();
        }

        static List<Models.Barn> Find(List<Models.Barn> allBørn, double vægt)
        {
            var result = allBørn.Where(x => x.Vægt > vægt).ToList();
            return result;
        }
    }
}
