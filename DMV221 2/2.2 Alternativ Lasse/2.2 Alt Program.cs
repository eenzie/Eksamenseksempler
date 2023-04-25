using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Alternativ_Lasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the method
            var lowNumber = GetLowerstAndHighestNumber(10, 40, 70, out int highNumber);

            // Output the results to console
            Console.WriteLine($"Higest number: {highNumber}");
            Console.WriteLine($"Lowest number: {lowNumber}");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the lowest and highest number in the input numbers
        /// </summary>
        /// <param name="first">provide first number</param>
        /// <param name="second">provide second number</param>
        /// <param name="third">provide third number</param>
        /// <param name="highestNumber">outputs highest number</param>
        /// <returns></returns>
        static int GetLowerstAndHighestNumber(int first, int second, int third, out int highestNumber)
        { 
            List<int> ints = new List<int>();
            ints.Add(first);
            ints.Add(second);
            ints.Add(third);

            highestNumber = ints.Max();
            return ints.Min();
        }
    }
}
