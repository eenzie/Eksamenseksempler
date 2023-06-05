using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2_Tekstfiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> vaegtListe = new List<decimal>();

            //foreach (var item in System.IO.File.ReadAllLines("input.txt"))
            //{
            //    vaegtListe.Add(Decimal.Parse(item));
            //}

            decimal value = 0;

            foreach (var item in System.IO.File.ReadAllLines("input.txt"))
            {
                if (Decimal.TryParse(item, out value))
                    vaegtListe.Add(value);
                else
                    Console.WriteLine("Unable to parse item '{0}'.", value);
            }

            var vaegteOVer30kg = vaegtListe.Where(x => x > 30).ToList();

            string textoutput = "";
            foreach (var item in vaegteOVer30kg)
            {
                textoutput += item + Environment.NewLine;
            }

            var antalBoernOver30kg = vaegteOVer30kg.Count();

            textoutput +=
                $"Antal børn over 30kg: {antalBoernOver30kg.ToString()}";

            System.IO.File.WriteAllText("output.txt", textoutput);
            Console.Write("Resultaterne er skrevet til filen output.txt");

            Console.ReadLine();
        }
    }
}
