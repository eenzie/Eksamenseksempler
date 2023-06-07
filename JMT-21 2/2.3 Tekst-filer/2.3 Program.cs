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

            List<int> talListe = new List<int>();

            foreach (var item in System.IO.File.ReadAllLines("tal1.txt"))
            {
                talListe.Add(Int32.Parse(item));
            }

            foreach (var item in System.IO.File.ReadAllLines("tal2.txt"))
            {
                talListe.Add(Int32.Parse(item));
            }

            int sum = talListe.Sum();

            textoutput = sum.ToString();

            System.IO.File.AppendAllText("sum.txt", Environment.NewLine + textoutput);
            Console.Write("Resultaterne er skrevet til filen sum.txt");

            Console.ReadLine();
        }
    }
}
