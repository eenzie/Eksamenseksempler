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

            List<double> salgsListe = new List<double>();
            foreach (var item in System.IO.File.ReadAllLines("salg.txt"))
            {
                salgsListe.Add(double.Parse(item));
            }

            var returnVarer = salgsListe.Where(x => x < 0).ToList();

            foreach (var item in returnVarer)
            {

                textoutput += "Returneret: " + item + Environment.NewLine;
            }

            var returnVarerTotal = returnVarer.Sum(x => x);
            var returnVarerAntal = returnVarer.Count();

            textoutput +=
                $"Returnvarer total: {returnVarerTotal.ToString("#.##")}. " +
                $"Returnvarer antal: {returnVarerAntal}";

            System.IO.File.WriteAllText("returvarer.txt", textoutput);
        }
    }
}
