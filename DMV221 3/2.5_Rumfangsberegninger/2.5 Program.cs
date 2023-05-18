using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Rumfangsberegninger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Models.Vare> varer = new List<Models.Vare>();

            varer.Add(new Models.Vare(1, 5, 2, 2.8));
            varer.Add(new Models.Vare(2, 1, 5, 1.5));
            varer.Add(new Models.Vare(3, 0.4, 0.9, 5));
            varer.Add(new Models.Vare(4, 1.3, 2.7, 1.1));

            foreach (var vare in varer)
            {
                Console.WriteLine(
                    $"Varenr: {vare.VareNr} -> {vare.Bredde} x {vare.Længde} x {vare.Højde}m = {vare.BeregnRumfang()}m2");
            }

            var totalrumfang = varer.Sum(x => x.BeregnRumfang());

            var gennemsnitsrumfang = totalrumfang / varer.Count();
            Console.WriteLine($"Total-rumfang: {totalrumfang}");
            Console.WriteLine($"Gennemsnits-rumfang: {gennemsnitsrumfang}");

            Console.ReadLine();
        }
    }
}
