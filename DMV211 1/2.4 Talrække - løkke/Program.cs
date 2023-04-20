using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Talrække___løkke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objektiv A: 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31");
            int a = 1;
            while (a <= 31)
            {
                Console.WriteLine(a);
                a += 3;
            }

            Console.WriteLine("Objektiv B: 9,99,999,9999,99999,999999,9999999");
            int b = 9;
            while (b <= 9999999)
            {
                Console.WriteLine(b);
                b = (b * 10) + 9;
            }

            Console.ReadLine();
        }
    }
}
