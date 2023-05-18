using System;
using System.Linq;

namespace _2._4_Optællingsmetode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of numbers
            int[] talArray = { 34, 75, 100, 17, 970, 9, 70, 1, 21, 60 };

            var talOver20 = 0;
            var talUnder10 = 0;
            talUnder10 = Find(talArray, out talOver20);

            Console.WriteLine($"Tal under 10: {talUnder10} og tal over 20: {talOver20}");
            //Console.WriteLine("Tal under 10 : " + talUnder10 + ". Talover 20 : " + talOver20);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Method for finding numbers below 10 and numbers above 20 in an array of integers
        /// </summary>
        /// <param name="talArray"></param>
        /// <param name="talOver20"></param>
        /// <returns>
        /// Numbers under 10 and 
        /// numbers above 20 (out parameter)
        /// </returns>
        private static int Find(int[] talArray, out int talOver20)
        {
            var talUnder10 = talArray.Where(x => x < 10).ToList();

            talOver20 = talArray.Where(x => x > 20).ToList().Count();

            return talUnder10.Count();
        }
    }
}
