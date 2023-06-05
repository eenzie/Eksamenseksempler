using _2._6_Ansat_klasse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._6_Ansat_klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opretter en liste af ansatte
            List<Ansat> ansatte = new List<Ansat>();
            ansatte.Add(new Ansat(1, "Hans Hansen", 25000));
            ansatte.Add(new Ansat(2, "Jens Jensen", 28000));
            ansatte.Add(new Ansat(3, "Peter Petersen", 31000));
            ansatte.Add(new Ansat(4, "Jørgen Jørgensen", 39000));

            // Ændrer alle ansattes løn med minus 2000
            Ansat.LoenAendring(ansatte, -2000);

            // Instantiere min og max løn variabler
            double maxLoen = 0;
            double minLoen = 0;

            // Kalder metode til at finde min og max løn
            minLoen = Ansat.FindMaxMin(ansatte, out maxLoen);

            // Skriver til console
            Console.WriteLine($"Max. løn: {minLoen}");
            Console.WriteLine($"Min. løn: {maxLoen}");
            Console.WriteLine();

            // Udskriver detailjer på ansatte med løn under 30000kr
            Console.WriteLine($"Ansatte med månedløn under 30000kr.:");
            foreach (var ansat in ansatte)
            {
                if (ansat.Maanedsloen <= 30000)
                    Console.WriteLine($"{ansat.Nr}, {ansat.Navn}, {ansat.Maanedsloen.ToString("C")}");
            }
            Console.WriteLine();

            // Udregner summen af alle lønninger of udskriver til console
            var sumAnsattesLoen = ansatte.Sum(x => x.Maanedsloen);
            Console.WriteLine($"Summen af de ansattes løn: {sumAnsattesLoen.ToString("C")}");

            Console.ReadLine();
        }
    }
}
