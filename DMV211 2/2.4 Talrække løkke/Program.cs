using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Talrække_løkke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objektiv A: 6, 36, 216, 1296, 7776, 46656, 279936");
            int a = 6;
            while (a <= 279936)
            {
                Console.WriteLine(a);
                a = a * 6;
            }

            Console.WriteLine("Objektiv B: 4, 44, 444, 4444, 44444, 444444, 4444444, 44444444");
            int b = 4;
            while (b <= 44444444)
            {
                Console.WriteLine(b);
                b = b * 10 + 4;
            }

            Console.ReadLine();
        }
    }
}
