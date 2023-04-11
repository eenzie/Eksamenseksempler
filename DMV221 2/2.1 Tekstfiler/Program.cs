using System.Collections.Generic;
using System.Linq;

namespace _2._1_Tekstfiler
{
    internal class Program
    {
        /// <summary>
        /// Extracts data from text file, calculates values from data and prints results to another text file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Extracts the decimals from the text file to a list variable
            var vegt = System.IO.File.ReadAllLines("vegt.txt").ToList();

            //Converts the string list to a decimal list
            List<double> vegtListe = new List<double>();
            foreach (var item in vegt)
            {
                vegtListe.Add(double.Parse(item));
            }

            // LINQ query to extract the count of screws more than 2g
            var skruerOver2g = vegtListe.Where(x => x > 2).Count();

            // LINQ query to extract count of the screws less than 1g
            var skruerUnder1g = vegtListe.Where(x => x < 1).Count();

            // Selection statement to extract the screws between 1g and 2g to new list
            List<double> skruerMellem1og2g = new List<double>();

            foreach (var item in vegtListe)

                if ((item >= 1) && (item <= 2))
                {
                    skruerMellem1og2g.Add(item);
                }
            // Calculates the average weight
            var gennemsnitsVaegt = skruerMellem1og2g.Sum() / skruerMellem1og2g.Count();

            // variable to hold the output for the text file
            string dataoutput = "";
            // generates the text to be written, limiting the decimal output to 2 decimal points with ToString('#.##')
            dataoutput +=
                $"Antallet af skruer under 1g er {skruerUnder1g}. " +
                $"Antallet af skruer over 2g er {skruerOver2g}. " +
                $"Gennemsnitsvægten for skruer mellem 1g og 2g er {gennemsnitsVaegt.ToString("#.##")}.";

            // writes the text to the new text file
            System.IO.File.WriteAllText("kvalitet.txt", dataoutput);
        }
    }
}
