using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._6_Hus_klasse.Models;

namespace _2._6_Hus_klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hus> huse = new List<Hus>();

            huse.Add(new Hus(47, "Odinsvej", 7100, "Vejle", 150, 2));
            huse.Add(new Hus(2, "Storegade", 6780, "Skærbæk", 100, 1));
            huse.Add(new Hus(188, "Boulevarden", 7100, "Vejle", 200, 3));
            huse.Add(new Hus(7, "Svanegade", 8200, "Struer", 100, 1));

            foreach (var item in huse)
            {
                var pris = item.BeregnPris(item.PostNr, item.Badeværelser);
                Console.WriteLine($"PRIS: {pris.ToString("C")} Adresse: {item.HusNr} {item.Adresse}, {item.PostNr} {item.ByNavn}. Kvm: {item.Størrelse}. Antal badeværelser: {item.Badeværelser}");
            }

            var totalPris = huse.Sum(item => item.BeregnPris(item.PostNr, item.Badeværelser));
            Console.WriteLine($"TOTAL PRIS: {totalPris.ToString("C")}");

            Console.ReadLine();
        }
    }
}
