using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Optælling_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 3, 7, 10, 17, 97, 9, 7, 33, 50, 10, 20, 6, 51 };

            var modulusCount = 0;
            var singleDigitCount = 0;

            singleDigitCount = Find(numArray, out modulusCount);

            Console.WriteLine($"Antal tal der kan divideres med 10: {modulusCount}");
            Console.WriteLine($"Antal enkeltcifrede tal: {singleDigitCount}");
            Console.ReadLine();
        }

        private static int Find(int[] array, out int modulus)
        {
            var singleDigitCount = array.Where(x => (x > 0) && (x < 10)).Count();
            modulus = array.Where(x => x % 10 == 0).Count();

            return singleDigitCount;
        }
    }
}
