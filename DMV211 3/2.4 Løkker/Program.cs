using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Løkker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                string output = "";
                for (int a = 1; a <= i; a++)
                {
                    output += $"{a} ";
                }
                Console.WriteLine($"{output} ");
            }
            Console.WriteLine();

            int b = 99;
            while (b >= 1)
            {
                Console.WriteLine(b);
                b = (b / 2);
            }

            Console.ReadLine();
        }
    }
}
