using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfiler___Vægt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vægt = System.IO.File.ReadAllLines("vegt.txt").ToList();

            List<int> vægtListe = new List<int>();
            foreach (var item in vægt)
            {
                vægtListe.Add(Int32.Parse(item));
            }

            //0-50 gram
            var gruppeA = vægtListe.Where(x => x <= 50).Count();
            //51-100 gram
            var gruppeB = vægtListe.Where(x => (x > 50) && (x<=100)).Count();
            //101-200 gram
            var gruppeC = vægtListe.Where(x => (x > 100) && (x <= 200)).Count();
            //over 200 gram
            var gruppeD = vægtListe.Where(x => x > 200).Count();
            //alle vægte
            var totalVare = vægtListe.Count();

            string dataoutput = "";

            dataoutput += $"Antal vare med vægt under 50 gram: {gruppeA}" + Environment.NewLine;
            dataoutput += $"Antal vare med vægt mellem 51 og 100 gram: {gruppeB}" + Environment.NewLine;
            dataoutput += $"Antal vare med vægt mellem 101 og 200 gram: {gruppeC}" + Environment.NewLine;
            dataoutput += $"Antal vare med vægt over 200 gram: {gruppeD}" + Environment.NewLine;
            dataoutput += $"Antal vare i alt: {totalVare}";

            System.IO.File.AppendAllText("statistik.txt", dataoutput);
            Console.Write("Resultaterne er skrevet til filen statistik.txt");
            Console.ReadLine();
        }
    }
}
