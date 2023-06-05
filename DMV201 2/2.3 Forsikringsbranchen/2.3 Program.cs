using System;

namespace _2._3_Forsikringsbranchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var erstatning = BeregnErstatning(2000, 5);
            Console.WriteLine($"Erstatningen vil være: {erstatning.ToString("C")}");
            Console.ReadLine();
        }

        static decimal BeregnErstatning(decimal priceNew, int age)
        {
            decimal erstatning = 0;

            if (age <= 1)
            {
                erstatning = priceNew * 1;
            }
            else if (age > 1 && age <= 6)
            {
                erstatning = priceNew * 0.75m;
            }
            else
            {
                erstatning = priceNew * 0.25m;
            }

            return erstatning;
        }
    }
}
