using System;

namespace _2._4_Løkker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Løkke 1");

            int a = -1280;
            while (a <= -10)
            {
                Console.WriteLine(a);
                a = (a / 2);
            }

            Console.WriteLine();
            Console.WriteLine("Løkke 2");

            int x = 1;
            int y = 1;
            int b = 3;

            while ((x <= 9) && (y <= 81))
            {
                Console.WriteLine(x);
                x++;
                Console.WriteLine(y);
                y = y + b;
                b += 2;
            }

            Console.ReadLine();
        }
    }
}
