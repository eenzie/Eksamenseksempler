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
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Rytter> ryttere = new List<Rytter>();

            ryttere.Add(new Rytter(4, "Mickey Mouse", 7.53));
            ryttere.Add(new Rytter(1, "Rasmus Klump", 6.83));
            ryttere.Add(new Rytter(3, "Anders And", 14.79));
            ryttere.Add(new Rytter(2, "Pelle Haleløs", 5.19));

            foreach (var rytter in ryttere)
            {
                Console.WriteLine($"Nr. {rytter.Nummer}, {rytter.Navn}. Tid: {rytter.Tid}.");
            }

            Rytter vinder = ryttere[0];
            foreach (var rytter in ryttere)
            {
                if (rytter.Tid < vinder.Tid)
                    vinder = rytter;
            }
            Console.WriteLine($"Vinderen er.... Nr. {vinder.Nummer}, {vinder.Navn}, med tiden {vinder.Tid}.");

            var totalTid = ryttere.Sum(x => x.Tid);
            var gennemsnitsTid = totalTid / ryttere.Count();
            Console.WriteLine($"Gennemsnitstiden var: {gennemsnitsTid}.");

            Console.ReadLine();
        }
    }
}
