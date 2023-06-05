using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_SumNegativePositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 3, -1, -10, 6, 9, 2, -7, 1 };

            var positiveSum = 0;
            var negativeSum = 0;

            negativeSum = SumNegativePositive(numArray, out positiveSum);

            Console.WriteLine($"Summen af negative tal: {negativeSum}");
            Console.WriteLine($"Summen af positive tal: {positiveSum}");
            
            Console.ReadLine();
        }

        private static int SumNegativePositive(int[] array, out int positiveSum)
        {
            int negativeSum = array.Where(x => x < 0).Sum();
            positiveSum = array.Where(x => x >= 0).Sum();

            return negativeSum;
        }
    }
}
