using _2._6_Klasse_Bilvurdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Klasse_Bilvurdering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bil> biler = new List<Bil>();

            biler.Add(new Bil("AB12345", 100000.00, 2021, 30000, 0.95, true));
            biler.Add(new Bil("BC12345", 150000.00, 2023, 53000, 0.75, false));
            biler.Add(new Bil("DE12345", 200000.00, 2019, 120000, 0.50, false));
            biler.Add(new Bil("FG12345", 80000.00, 2023, 11000, 0.95, true));

            foreach (var item in biler)
            {
                var pris = item.Vurdering();
                bool klima = true;
                Console.WriteLine($"BRUGT PRIS: {pris.ToString("C")} " +
                    $"Reg: {item.RegNr}. " +
                    $"Årgang: {item.Aargang}. " +
                    $"Km: {item.Odometer}. " +
                    $"Stand: {item.Stand}. " +
                    $"Klimaanlæg: {(item.Klima ? "Ja" : "Nej")}");
            }

            var totalPris = biler.Sum(item => item.Vurdering());
            Console.WriteLine($"ALLE BILER TOTAL: {totalPris.ToString("C")}");
            Console.ReadLine();
        }
    }
}
