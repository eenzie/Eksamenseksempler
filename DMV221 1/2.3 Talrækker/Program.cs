using System;

namespace _2._3_Talrækker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Del 1: 0.5, 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4,5, 5.0");

            decimal x = 0.5M;

            while (x <= 5.0M)
            {
                Console.WriteLine(x);
                x += 0.5M;
            }

            Console.WriteLine("Del 2: 10, 8, 12, 6, 14, 4, 16, 2, 18, 0");

            int a = 10;
            int b = 8;

            while ((a <= 18) && (b >= 0))
            {
                Console.WriteLine(a);
                a += 2;
                Console.WriteLine(b);
                b += -2;
            }
            Console.ReadLine();
        }
    }
}
