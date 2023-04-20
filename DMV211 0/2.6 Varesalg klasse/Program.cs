using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._6_Varesalg_klasse.Models;

namespace _2._6_Varesalg_klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vare> varer = new List<Vare>();

            varer.Add(new Vare(1, "Sokker", 7.15, 300));
            varer.Add(new Vare(2, "Skjorter", 60.00, 25));
            varer.Add(new Vare(3, "T-Shirts", 15.00, 800));
            varer.Add(new Vare(4, "Bukser", 100.00, 7));

            Console.WriteLine("*** Almindelig pris ***");

            foreach (var item in varer)
            {
                Console.WriteLine($"Vare nr. {item.VareNr}, vare navn: {item.VareNavn}. Salgspris: {item.SalgsPris.ToString("0.00")}kr. Antal stk: {item.Antal}");
            }

            Console.WriteLine("*** Ny pris ***");

            foreach (var item in varer)
            {
                var nySalgspris = item.PrisAendring(5);
                Console.WriteLine($"Vare nr: {item.VareNr}. Vare navn: {item.VareNavn}. Ny salgspris: {nySalgspris.ToString("0.00")}kr. Antal stk: {item.Antal}");
            }

            Console.ReadLine();
        }
    }
}
