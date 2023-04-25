using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int addNumber = 2;
            int currentValue = 1;

            string output = "";
            int round = 0;
            while (round < 10)
            {
                round++;
                output += currentValue + " ";
                currentValue = currentValue + addNumber;
                addNumber++;
            }
            Console.WriteLine(output);

            int b = 9999999;
            while (b >= 9)
            {
                Console.Write(b + " ");
                b = (b / 10);
            }

            Console.ReadLine();
        }
    }
}
