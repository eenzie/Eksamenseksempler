using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._1_Tekstfiler
{
    internal class Program
    {
        /// <summary>
        /// Opgave 2.1 Tekstfiler
        /// Calculations with text file input and output
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Extracts weight data from text file
            var pakkeliste = System.IO.File.ReadAllLines("pakker.txt").ToList();

            // variable to hold the output for the output text file
            string textoutput = "";

            // Converts the weight data to a list variable
            List<double> pakkevaegte = new List<double>();
            foreach (var item in pakkeliste)
            {
                pakkevaegte.Add(double.Parse(item));
            }

            // LINQ query to extract packages over 30kg
            var pakkerover30kg = pakkevaegte.Where(x => x > 30).ToList();
            // Foreach loop to add each of those extracted to the output text variable
            foreach (var item in pakkerover30kg)
            {
                textoutput += "Pakke vægt : " + item + Environment.NewLine;
            }

            // LINQ query to extract the packages under 30kg
            var pakkerunder30kg = pakkevaegte.Where(x => x < 30).ToList();
            // Calculation to determine, first the sum, then the average weight of the packages under 30kg
            var totalvaegt = pakkerunder30kg.Sum(x => x);
            var gennemsnitsvaegtforpakkerunder30kg = totalvaegt / pakkerunder30kg.Count();

            // Adds the average weight result to the output text variable
            textoutput += "Gennemsnitsvægt af pakker under 30 kg er :" + gennemsnitsvaegtforpakkerunder30kg;
            //Alternative using interpolation
            //textoutput += $"Gennemsnitsvægt af pakker under 30 kg er : {gennemsnitsvaegtforpakkerunder30kg}";

            // Writes the output text variables to the output text file
            System.IO.File.WriteAllText("pakkeoversigt.txt", textoutput);
        }
    }
}
