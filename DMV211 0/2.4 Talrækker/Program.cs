using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Talrækker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objektiv A: 30, 27, 24, 21, 18, 15, 12, 9, 6, 3, 0");
            int a = 30;
            while (a >= 0)
            {
                Console.WriteLine(a);
                a += -3;
            }

            Console.WriteLine("Objektiv B: 7, 49, 343, 2401, 16807, 117649, 823543");
            int b = 7;
            while (b <= 823543)
            {
                Console.WriteLine(b);
                b = b * 7;
            }

            Console.WriteLine("Objektiv C: 1,2,2,4,3,8,4,16,5,32,6,64,7,128,8,256,9,512,10,1024");
            int x = 1;
            int y = 2;
            while ((x <= 10) && (y <= 1024))
            {
                Console.WriteLine(x);
                x ++;
                Console.WriteLine(y);
                y = y * 2;
            }

            Console.ReadLine();
        }
    }
}
