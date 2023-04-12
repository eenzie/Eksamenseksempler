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
            //OPGAVE B
            for (int i = -6; i < 11; i++)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


            //OPGAVE B
            for (int timer = 0; timer <= 23; timer++)
            {
                for (int minutter = 0; minutter <= 59; minutter++)
                {
                    Console.WriteLine($"Klokken er {timer.ToString("00")}:{minutter.ToString("00")}");
                }
            }
            Console.ReadLine();
        }
    }
}
