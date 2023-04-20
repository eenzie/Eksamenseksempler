using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _2_5_Brille_Rabat.Models;

namespace _2._5_Brille_Rabat
{
    internal class Program
    {
        /// <summary>
        /// Main method, includes 4 object arrays
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Brille> briller = new List<Brille>();

            briller.Add(new Brille(1, "Chanel", 1899.00, 14));
            briller.Add(new Brille(2, "Police", 799.00, 3));
            briller.Add(new Brille(3, "Gucci", 2000.00, 1));
            briller.Add(new Brille(4, "Mui", 599.00, 36));

            foreach (var brille in briller)
            {
                Console.WriteLine($"Vare nr: {brille.VareNr}. " +
                    $"- Brille navn: {brille.BrilleNavn}. " +
                    $"- Salgspris: {brille.SalgsPris.ToString("C")}. " +
                    $"- Rabat pris: {brille.RabatPris().ToString("C")}. " +
                    $"- Antal: {brille.Antal}stk.");
            }

            double totalSalgspris = 0;
            double totalRabatPris = 0;

            foreach (var brille in briller)
            {
                totalSalgspris += brille.SalgsPris * brille.Antal;
                totalRabatPris += brille.RabatPris() * brille.Antal;
            }

            Console.WriteLine($"Total salgspris: {totalSalgspris.ToString("C")}");
            Console.WriteLine($"Total rabat pris: {totalRabatPris.ToString("C")}");

            Console.ReadLine();
        }
    }
}
