using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Talrækker
{
    internal class Program
    {
        /// <summary>
        /// Loop methods for:
        /// 1) a list of decimal number incrementally increasing by 0.1 per iteration
        /// 2) printing a list of numbers divided by the previous number
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Sets starting decimal variable to be 0.1
            decimal a = 0.1M;

            // While loop that runs while the decimal is less than 1,
            // adding 0.1 to the next iteration
            while (a < 1M)
            {
                Console.WriteLine(a);
                a += 0.1M;
            }
            Console.ReadLine();

            // Sets starting integer varible to be 403
            int b = 403;

            // While loop that runs while the integer is more than 0
            // diving the number with 2 each time.
            // (note: integer divisions are always rounded down)
            while (b > 0)
            {
                Console.WriteLine(b);
                b = b / 2;
            }
            Console.ReadLine();
        }
    }
}
