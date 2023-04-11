using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Tekstfiler
{
    internal class Program
    {
        /// <summary>
        /// Extracts highest value of list of decimals from a text file
        /// and calculates the average of the list of decimals
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Extracts the decimals fromteh text file to a list variable
            var benzinpriser = System.IO.File.ReadAllLines("benzinpriser.txt").ToList();
            //Converts the string list to a decimal list
            List<decimal> priceList = new List<decimal>();
            foreach (var item in benzinpriser)
            {
                priceList.Add(decimal.Parse(item));
            }

            // linq query to extract the higest price
            var highestPrice = priceList.Max(x => x);
            // linq query to calcualte the average price
            var totalPrice = priceList.Sum(x => x);
            var averagePrice = totalPrice / priceList.Count();

            // variable to hold the output for the text file
            string dataoutput = "";
            // generates the text to be written, limiting the decimal output to 2 decimal points with ToString('#.##')
            dataoutput += $"Gennemsnitsprisen for benzin var {averagePrice.ToString("#.##")} og den højeste pris var {highestPrice.ToString("#.##")}";
            // writes the text to the new text file
            System.IO.File.WriteAllText("oversigt.txt", dataoutput);
        }
    }
}