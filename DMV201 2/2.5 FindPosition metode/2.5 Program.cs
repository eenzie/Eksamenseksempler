using System;

namespace _2._5_FindPosition_metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 7, 6, 4, 2, 8, 5 };

            // Using the array provided in the assignment
            int[] ExampleArray = { 31, 11, 10, 26, 9, 29, 67, 51 };

            // Random number generator for number between 1 and 10
            Random random = new Random();
            int searchNum = random.Next(1, 10);

            // Quick test alternative to random number
            //int searchNum = 5; //returns index of 5

            // Quick test alternative to random number
            //int searchNum = 1; //returns index of -1

            // Using the number provided in the assignment 
            int exampleSearchNum = 9;

            Console.WriteLine($"Tilfældigt søgenummer: {searchNum}");
            Console.WriteLine($"Nummerets position: {FindPosition(numArray, searchNum)}");

            Console.WriteLine();

            Console.WriteLine($"Eksempel søgenummer: {exampleSearchNum}");
            Console.WriteLine($"Nummerets position: {FindPosition(ExampleArray, exampleSearchNum)}");

            Console.ReadLine();
        }

        /// <summary>
        /// Finds the array index of a number
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rdmNum"></param>
        /// <returns>The index of the number if found, the default vaue if not found</returns>
        static int FindPosition(int[] array, int searchNum)
        {
            // Default return value for when number is not found in array
            int result = -1;

            foreach (int i in array)
            {
                if (i == searchNum)
                {
                    result = Array.IndexOf(array, searchNum);
                }
            }

            return result;
        }
    }
}
