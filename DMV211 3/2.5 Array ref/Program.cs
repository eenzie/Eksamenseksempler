using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._5_Array_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a two-dimensional array
            int[,] tal = new int[5, 2]
                    {
                        { 8, -2 },
                        { 6, 3 },
                        { -2, -3 },
                        { -6, 9 },
                        { 8, -8 },
                    };

            // Call the Beregn method with the tal array and out parameters to store the sums
            int positivSum, negativSum = 0;
            negativSum = Beregn(tal, out positivSum);

            // Output the sums for each
            Console.WriteLine($"Summen af negativ tal: {negativSum}");
            Console.WriteLine($"Summen af positive tal: {positivSum}");

            Console.ReadLine();
        }

        private static int Beregn(int[,] array, out int positiv)
        {
            // Initialize variables for the sum of negative and positive numbers
            var negativ = 0;
            positiv = 0;

            // Loop through all elements of the 2D array
            // First rows...
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Then columns
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Check if the current element is positive
                    if (array[i, j] < 0)
                        negativ += array[i, j];
                    // Check if the current element is negative
                    else if (array[i, j] > 0)
                        positiv += array[i, j];
                }
            }
            // Return the sum of negative numbers
            return negativ;
        }
    }
}
