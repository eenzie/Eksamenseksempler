using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] byer = { "Esbjerg", "Aarhus", "Fredericia", "Faaborg", "Herning", "Rudkøbing", "Nykøbing", "Andkær"};

            //Sorts 'Aa' as 'Å' when current culture default is DK
            Array.Sort(byer);
            //Alternative sort that disregards culture
            //Array.Sort(byer, StringComparer.InvariantCulture);

            string[] fByer = FByer(byer);
            string[] ingByer = IngByer(byer);

            Console.WriteLine("Alle byer:");
            foreach (var item in byer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Byer der starter med F:");
            foreach (var item in fByer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Byer der ender på ing:");
            foreach (var item in ingByer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        public static string[] FByer(string[] array)
        {
            return array.Where(x => x.StartsWith("F")).ToArray();
        }

        public static string[] IngByer(string[] array)
        {
            return array.Where(x => x.EndsWith("ing")).ToArray();
        }
    }
}

