using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfiler.Services
{
    public class StatisticCalculator
    {
        public string BilDataPath { get; set; }

        public StatisticCalculator()
        {
            // When just using the filename it will use the filepath
            // of where the programme is running. So it will save it
            // in the same folder as the exe file.
            BilDataPath = "bildata.txt";
        }

        /// <summary>
        /// Filter car data from bildata.text text file 
        /// and print result to new text file statistik.txt
        /// </summary>
        public void WriteStaticsFile()
        {
            try
            {
                // the variable is automatically a string array
                var allLines = System.IO.File.ReadAllLines(BilDataPath);

                // Shows LINQ
                var carsWithErrors = allLines.Where(x => int.Parse(x) >= 4).ToList();

                // Shows loops
                var carsWithZeroErrorsCount = 0;
                foreach (var line in allLines)
                {
                    if (int.Parse(line) == 0)
                    {
                        carsWithZeroErrorsCount++;
                    }
                }

                // create variable that equals the sum of the array of the text file
                // (parsed the string to an int)
                var totalAmountOfErrors = allLines.Sum(x => int.Parse(x));
                var totalAmountOfCars = allLines.Count();
                var avarageAmountOfErrors = totalAmountOfErrors / totalAmountOfCars;

                string output = "";

                output += "Biler med 4 eller flere fejl" + Environment.NewLine;
                foreach (var item in carsWithErrors)
                {
                    output += item + Environment.NewLine;
                }

                output += "Antal af biler med nul fejl " + carsWithZeroErrorsCount + Environment.NewLine;
                output += "Gennemsnitsfejl på biler " + avarageAmountOfErrors + Environment.NewLine;

                System.IO.File.WriteAllText("statisk.txt", output);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
