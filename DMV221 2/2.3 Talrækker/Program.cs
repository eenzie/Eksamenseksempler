using System;

namespace _2._3_Talrækker
{
    internal class Program
    {
        /// <summary>
        /// Alternating loop statement
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Sets 2 starting variable integers
            int a = -12;
            int b = 16;

            // Multiple while loop that alternates between the 2 variables and prints to console
            while ((a <= -7) && (b >= 1))
            {
                Console.WriteLine(a);
                a += 1;
                Console.WriteLine(b);
                b += -3;
            }
            Console.ReadLine();
        }
    }
}
