using System;
using System.Linq;

namespace _2._2_Find_største_og_mindste_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of numbers
            int[] talArray = { 10, 13, 5 };

            var largestNumber = 0;
            var smallestNumber = 0;

            // Calls the method
            smallestNumber = Find(talArray, out largestNumber);

            Console.WriteLine($"Mindste tal: {smallestNumber}");
            Console.WriteLine($"Største tal: {largestNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Method for finding the smallest and the largest number in an array of integers
        /// </summary>
        /// <param name="talArray"></param>
        /// <param name="largestNumber"></param>
        /// <returns>
        /// Smallest number and largest number (out parameter) of array
        /// </returns>
        private static int Find(int[] talArray, out int largestNumber)
        {
            var smallestNumber = talArray.Min(x => x);
            largestNumber = talArray.Max(x => x);
            return smallestNumber;
        }
    }
}
