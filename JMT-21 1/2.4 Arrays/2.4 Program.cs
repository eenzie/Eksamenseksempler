namespace _2._4_Arrays
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table = { { 15, 16, 17 }, { 18, 19, 20 } };

            UdskrivTabel(table);

            Console.ReadLine();
        }

        static void UdskrivTabel(int[,] table)
        {
            int rows = table.GetLength(0);
            int columns = table.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(table[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(table[j, i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
