using _2._6_Klasser.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._6_Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lampe> lamper = new List<Lampe>();

            lamper.Add(new Lampe(1, 2, "Rolle", "Jon Jonsen.", "Ikea", 1179.99));
            lamper.Add(new Lampe(1, 3, "Rasse", "Lars Larsen.", "Jysk", 3335.00));
            lamper.Add(new Lampe(3, 1, "Fimre", "Mads Madsen", "Sinnerup", 9999.99));
            lamper.Add(new Lampe(2, 3, "Polle", "Hans Hansen", "Magazin", 5999.99));

            Console.WriteLine($"Lamper over 5000kr.");

            foreach (var lampe in lamper)
            {
                if (lampe.Pris >= 5000)
                {
                    Console.WriteLine($"{lampe.ProduktNummer}, {lampe.Typekode}, {lampe.Lampenavn} af {lampe.Designernavn} ved {lampe.Producentnavn} til {lampe.Pris.ToString("C")}");
                }
            }
            Console.WriteLine();

            Lampe dearestLamp;
            Lampe cheapestLamp;
            FindLampeprisMinMax(lamper, out cheapestLamp, out dearestLamp);

            Console.WriteLine($"Billigste lampe:\n{cheapestLamp.Lampenavn} af {cheapestLamp.Designernavn} til {cheapestLamp.Pris.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"Dyreste Lampe:\n{dearestLamp.Lampenavn} af {dearestLamp.Designernavn} til {dearestLamp.Pris.ToString("C")}");

            Console.ReadLine();
        }

        static void FindLampeprisMinMax(List<Lampe> lamper, out Lampe cheapestLamp, out Lampe dearestLamp)
        {
            cheapestLamp = lamper.OrderBy(x => x.Pris).FirstOrDefault();
            dearestLamp = lamper.OrderByDescending(x => x.Pris).FirstOrDefault();
        }
    }
}
