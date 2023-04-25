using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Udregn_metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create array of integers
            int[] helTalArray = { 31, 11, 10, 26, 9, 29, 67, 51 };

            var firstNum = 0;
            var lastNum = 0;

            // Calls the method
            firstNum = Udregn(helTalArray, out lastNum);

            Console.WriteLine($"Det første tal er: {firstNum}");
            Console.WriteLine($"Det sidste tal er: {lastNum}");

            Console.ReadLine();
        }

        /// <summary>
        /// Finds the first and the last element of an integer array
        /// </summary>
        /// <param name="numberArray">Array of integers</param>
        /// <param name="lastNum">Out parameter for last number in array</param>
        /// <returns>first number in array</returns>
        private static int Udregn(int[] numberArray, out int lastNum)
        {
            int firstNum = numberArray.First();
            lastNum = numberArray.Last();

            return firstNum;
        }
    }
}
