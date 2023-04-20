using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfiler___Trafik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hastigheder = System.IO.File.ReadAllLines("trafik.txt").ToList();

            List<int> hastighedsListe= new List<int>();

            foreach (var item in hastigheder)
            {
                hastighedsListe.Add(Int32.Parse(item));
            }

            //0-50 km/t
            var gruppeA = hastighedsListe.Where(x => x <= 50).Count();
            //51-80 km/t
            var gruppeB = hastighedsListe.Where(x => (x > 50) && (x <= 80)).Count();
            //over 81 km/t
            var gruppeC = hastighedsListe.Where(x => x > 80).Count();
            //alle registreringer
            var totalAntal = hastighedsListe.Count();
            //Gennemsnitshastighed
            var gennemsnit = hastighedsListe.Sum() / hastighedsListe.Count();
            //max hastighed
            var maxHastighed = hastighedsListe.Max();

            string dataoutput = "";

            dataoutput += $"Hastigheder under 50 km/t: {gruppeA}" + Environment.NewLine;
            dataoutput += $"Hastigheder mellem 51 og 80 km/t: {gruppeB}" + Environment.NewLine;
            dataoutput += $"Hastigheder over 81 km/t: {gruppeC}" + Environment.NewLine;
            dataoutput += $"Registreringer i alt: {totalAntal}" + Environment.NewLine;
            dataoutput += $"Gennemsnitshastighed: {gennemsnit}" + Environment.NewLine;
            dataoutput += $"Højeste hastighed: {maxHastighed}";

            System.IO.File.AppendAllText("hastighed.txt", dataoutput);
            Console.Write("Resultaterne er skrevet til filen hastighed.txt");

            Console.ReadLine();
        }
    }
}
