using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_Tekst_filer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoutput = "";

            // Calls the method and adds to list
            List<int> resultatListe = FindTal();

            foreach (var item in resultatListe)
            {
                textoutput += item + ", ";
            }

            System.IO.File.WriteAllText("trecifre.txt", textoutput);
            Console.Write("Resultaterne er skrevet til filen trecifre.txt");
            Console.ReadLine();
        }

        static List<int> FindTal()
        {
            //Finds all numbers that do not contain zero between 400 and 599
            List<int> noZeroNums = new List<int> { };
            int num = 400;

            while (num < 600)
            {
                if (!num.ToString().Contains(0.ToString()))
                {
                    noZeroNums.Add(num);
                }
                num++;
            }

            //Then filters number from noZeroNums list, where all digits are unique
            List<int> uniqueNoZeroNums = new List<int> { };

            foreach (var number in noZeroNums)
            {
                string numberString = number.ToString();
                bool hasDuplicates = numberString.Distinct().Count() != numberString.Length;

                if (!hasDuplicates)
                {
                    uniqueNoZeroNums.Add(number);
                }
            }

            return uniqueNoZeroNums;
        }
    }
}
