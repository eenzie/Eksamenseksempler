using System;
using System.Linq;

namespace _2._4_Opsummeringsmetode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] salesArray = { 300, 75, 100, -170, 970, 90, 70, 105, -20, -60 };

            var sales = 0;
            var returns = 0;

            // Calls the method
            returns = Find(salesArray, out sales);

            Console.WriteLine($"Salgstotal: {sales}");
            Console.WriteLine($"Antal returneringer: {returns}");
            Console.ReadLine();
        }

        private static int Find(int[] salesArray, out int sales)
        {
            var returns = salesArray.Count(x => x < 0);
            sales = salesArray.Where(x => x > 0).Sum();

            return returns;
        }
    }
}

