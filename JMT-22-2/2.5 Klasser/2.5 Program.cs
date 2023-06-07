using _2._5_Klasser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Frimærke> frimærker = new List<Frimærke>();
            frimærker.Add(new Frimærke("Vilde fugle", 250.00, false));
            frimærker.Add(new Frimærke("Eventyr", 150.00, true));
            frimærker.Add(new Frimærke());
            frimærker.Add(new Frimærke("Dronning Magrethe II", 300.00, false));

            //Kalder metode til ændring a motiv på listeindex 2
            Frimærke.MotivÆndring(frimærker, "Hunderacer", 2);

            //Kalder metode til ændring a beløb på listeindex 2
            Frimærke.BeløbÆndring(frimærker, 125, 2);

            //Kalder metode til ændring a miniark på listeindex 2
            Frimærke.MiniarkÆndring(frimærker, true, 2);

            foreach (var item in frimærker)
            {
                Console.WriteLine($"Motiv: {item.Motivtekst}. Beløb: {item.Beløb.ToString("C")} Miniark: {(item.Miniark ? "Ja" : "Nej")}");
            }
            Console.ReadLine();
        }
    }
}
