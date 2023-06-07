using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Iterationer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Talrække A (Math.Pow())
            double[] array = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in array)
            {
                Console.Write(Math.Pow(item, 2) + " ");
            }
            Console.WriteLine();

            // Talrække A (Alternativ)
            foreach (var item in array)
            {
                Console.Write(item * item + " ");
            }
            Console.WriteLine();

            // Talrække B: 20, 25, 30, 35, 40, 45, 50, 55, 60
            int b = 20;
            while (b <= 60)
            {
                Console.Write(b + " ");
                b += 5;
            }
            Console.WriteLine();

            //Bogstavrække C: F, G, H, I, J, K, L, M, N, O, P, Q
            for (char bogstav = 'F'; bogstav <= 'Q'; bogstav++)
            {
                Console.Write(bogstav + " ");
            }

            Console.ReadLine();
        }
    }
}
