using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoutput = "";

            List<int> dataListe = new List<int>();
            foreach (var item in System.IO.File.ReadAllLines("inddata.txt"))
            {
                dataListe.Add(Int32.Parse(item));
            }

            var negativeTal = dataListe.Where(x => x < 0).ToList();

            foreach (var item in negativeTal)
            {

                textoutput += "Negative tal: " + item + Environment.NewLine;
            }

            var antalNegativeTal = negativeTal.Count();

            textoutput +=
                $"Antal negative tal: {antalNegativeTal.ToString()}";

            System.IO.File.WriteAllText("uddata.txt", textoutput);
            Console.Write("Resultaterne er skrevet til filen uddata.txt");
            Console.ReadLine();
        }
    }
}
