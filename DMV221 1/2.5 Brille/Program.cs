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
            briller.Add(new Brille(3, "Gucci", 2899.00, 1));
            briller.Add(new Brille(4, "Mui", 599.00, 36));

            foreach (var brille in briller)
            {
                Console.WriteLine("Vare nr: "
                    + brille.VareNr + ". - Brille navn: "
                    + brille.BrilleNavn + " - Salgspris: "
                    + brille.Antal + " stk. - Rabat pris: "
                    + brille.SalgsPris + " kr. - Antal: "
                    + brille.RabatPris() + "kr.");
            }

            //VIRKER IKKE!
            //var totalSalgspris = Brille.antal * Brille.SalgsPris;
            //Virker, men ikke uden udregning ovenover
            //var totalRabatPris = briller.Sum(x => x.RabatPris());

            //Console.WriteLine($"Total salgspris: {totalSalgspris}");
            //Console.WriteLine($"Total rabat pris: {totalRabatPris}");

            Console.ReadLine();

        }
    }
}
