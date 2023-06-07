using _2._6_Klasser.Models;
using System;
using System.Collections.Generic;

namespace _2._6_Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Album> albummer = new List<Album>();

            albummer.Add(new Album(123456789, 1929, "Tintin i Sovjet", "Hergé", 30000, 120.00));
            albummer.Add(new Album(223456789, 1978, "Lucky Luke og Daltonbrødrene", "Morris", 20000, 110.00));
            albummer.Add(new Album(323456789, 1987, "Valhalla - Historien om Quark", "Peter Madsen", 5000, 150.00));
            albummer.Add(new Album(423456789, 1932, "Tintin i Amerika", "Hergé", 80000, 150.00));

            HergeBefore1990(albummer);
            Console.WriteLine();

            FindTotal(albummer, out double sumPris, out int sumOplag);

            Console.WriteLine($"Summen af albummets priser: {sumPris.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"Summen af albummets oplag: {sumOplag}");

            Console.ReadLine();
        }

        static void HergeBefore1990(List<Album> albummer)
        {
            bool foundMatch = false;
            int index = 0;

            while (index < albummer.Count)
            {
                var item = albummer[index];

                if (item.Udgivelsesår < 1990 && item.TegnerNavn == "Hergé")
                {
                    Console.WriteLine($"ISBN: {item.ISBN}. " +
                                      $"Udgivelsesår: {item.Udgivelsesår}. " +
                                      $"Titel: {item.Titel}. " +
                                      $"Tegner: {item.TegnerNavn}. " +
                                      $"Oplag: {item.Oplag}. " +
                                      $"Pris: {item.Pris.ToString("C")}");
                    foundMatch = true;
                }

                index++;
            }

            if (!foundMatch)
            {
                Console.WriteLine("Ikke fundet");
            }
        }

        static double FindTotal(List<Album> albummer, out double sumPris, out int sumOplag)
        {
            sumOplag = 0;
            sumPris = 0;

            foreach (var item in albummer)
            {
                sumPris += item.Pris;
                sumOplag += item.Oplag;
            }

            return sumPris;
        }
    }
}
