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

            foreach (var item in huse)
            {
                if (item.Pris >= 2000000)
                {
                    Console.WriteLine($" Adresse: {item.VejNavn} {item.HusNr} - Pris: {item.Pris.ToString("C")}");
                }
            }
         
            var lowestPrice = huse.Where(x => x.Pris > 2000000).Min(x => x.Pris);
            var totalPrice = huse.Where(x => x.Pris > 2000000).Sum(x => x.Pris);
            var averagePrice = totalPrice / huse.Where(x => x.Pris > 2000000).Count();

            Console.WriteLine($" Summen: {totalPrice.ToString("C")}");
            Console.WriteLine($" Gennemsnittet: {averagePrice.ToString("C")}");

            //var pris = item.PrisAendring(50);

            Console.ReadLine();
        }
    }
}
