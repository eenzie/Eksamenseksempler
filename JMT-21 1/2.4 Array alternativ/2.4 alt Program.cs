using System;

namespace _2._4_Array_alternativ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table = { { 15, 16, 17 }, { 18, 19, 20 } };

            UdskrivTabel(table);
            Console.WriteLine();

            Console.ReadLine();
        }

        static void UdskrivTabel(int[,] table)
        {
            int rows = table.GetLength(0);
            int columns = table.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                Console.Write($"Rk. {row}: ");

                for (int column = 0; column < columns; column++)
                {
                    Console.Write($"{table[row, column]} ");
                }

                Console.WriteLine();
            }

            for (int column = 0; column < columns; column++)
            {
                Console.Write($"Kol. {column}: ");

                for (int row = 0; row < rows; row++)
                {
                    Console.Write($"{table[row, column]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
