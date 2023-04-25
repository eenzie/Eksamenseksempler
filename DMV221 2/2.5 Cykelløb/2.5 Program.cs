using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._5_Cykelløb.Models;

namespace _2._5_Cykelløb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rytter> ryttere = new List<Rytter>();

            ryttere.Add(new Rytter(4, "Mickey Mouse", 7.53));
            ryttere.Add(new Rytter(1, "Rasmus Klump", 6.83));
            ryttere.Add(new Rytter(3, "Anders And", 14.79));
            ryttere.Add(new Rytter(2, "Pelle Haleløs", 5.19));

            foreach (var rytter in ryttere.Where(x => x != null))
            {
                try
                {
                    Console.WriteLine($"Rytter: {rytter.Nummer}, {rytter.Navn}. Tid: {rytter.Tid}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ugyldig Rytter: {ex}");
                }
            }

            var vinder = ryttere.OrderBy(x => x.Tid).First();

            // ALTERNATIVE
            //Rytter vinder = ryttere[0];
            //foreach (var rytter in ryttere)
            //{
            //    if (rytter.Tid < vinder.Tid)
            //        vinder = rytter;
            //}

            Console.WriteLine($"Vinderen er.... {vinder.Navn} med tiden {vinder.Tid}.");

            var totalTid = ryttere.Sum(x => x.Tid);
            var totalRyttere = ryttere.Count();
            var gennemsnitsTid = totalTid / ryttere.Count();
            Console.WriteLine($"Gennemsnitstiden var: {gennemsnitsTid}.");

            //eller
            //Console.WriteLine($"Gennemsnitstiden var: {totalTid / ryttere.Count()}.");

            Console.ReadLine();
        }
    }
}
