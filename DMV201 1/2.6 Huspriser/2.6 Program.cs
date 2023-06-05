using _2._6_Huspriser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Huspriser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hus> huse = new List<Hus>();

            huse.Add(new Hus(47, "Odinsvej", 3000000));
            huse.Add(new Hus(2, "Storegade", 1900000));
            huse.Add(new Hus(188, "Birkevej", 6000000));
            huse.Add(new Hus(7, "Svanegade", 1750000));

            // Calls method to change the price of a house 
            // parameters: List of houses, price change, list index of house to change
            Hus.PrisAendring(huse, -200000, 1);

            // Calls the HentBilligsteHus method
            Hus billigsteHus = Hus.HentBilligsteHus(huse);
            Console.WriteLine($"Billigste hus: {billigsteHus.VejNavn} {billigsteHus.HusNr}, {billigsteHus.Pris.ToString("C")}");

            // Finder huspriser højere end 2.000.000kr og udskriver til console
            Console.WriteLine($"Huse over 2 millioner:");
            foreach (var item in huse)
            {
                if (item.Pris >= 2000000)
                {
                    Console.WriteLine($"{item.VejNavn} {item.HusNr}, {item.Pris.ToString("C")}");
                }
            }

            // Finder summen af huse over 2.000.000kr og udskriver til console
            var sumPrice = huse.Where(x => x.Pris > 2000000).Sum(x => x.Pris);
            Console.WriteLine($"Summen af huse over 2 millioner: {sumPrice.ToString("C")}");

            // Finder gennemsnittet af huse over 2.000.000kr og udskriver til console
            var averagePrice = sumPrice / huse.Where(x => x.Pris > 2000000).Count();
            Console.WriteLine($"Gennemsnittetsprisen for huse over 2 millioner: {averagePrice.ToString("C")}");

            Console.ReadLine();
        }
    }
}
