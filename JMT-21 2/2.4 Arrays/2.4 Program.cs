using System;

namespace _2._4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[,] myArray = new decimal[,] { { 1.5m, 3.5m }, { 4.5m, 5.5m }, { 6.5m, 8.5m } };

            decimal[] rowSums = CalculateRowSums(myArray);

            foreach (decimal rowSum in rowSums)
            {
                Console.WriteLine(rowSum);
            }

            //Console.WriteLine(rowSums[0]);
            //Console.WriteLine(rowSums[1]);
            //Console.WriteLine(rowSums[2]);
            Console.ReadLine();
        }

        public static decimal[] CalculateRowSums(decimal[,] array)
        {
            int numRows = array.GetLength(0);
            int numCols = array.GetLength(1);

            decimal[] rowSum = new decimal[numRows];

            for (int i = 0; i < numRows; i++)
            {
                decimal sum = 0;
                for (int j = 0; j < numCols; j++)
                {
                    sum += array[i, j];
                }
                rowSum[i] = sum;
            }

            return rowSum;
        }
    }
}
