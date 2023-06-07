using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2_Iterationer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = FemRandom().ToList();

            foreach (int item in randomNumbers)
            {
                Console.Write(item.ToString() + ", ");
            }

            Console.ReadLine();
        }
        public static List<int> FemRandom()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            do
            {
                int lastNumber = random.Next(1, 10);

                // checks if the new random number is not equal to the last number and add to list
                if (!numbers.Contains(lastNumber))
                {
                    numbers.Add(lastNumber);
                }

            } while (numbers.Count < 5);

            return numbers;
        }
    }
}
