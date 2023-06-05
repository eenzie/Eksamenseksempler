using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Talrækker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. talrække: 400, 402, 404, 406, 408, 410, 412, 414, 416, 420
            int a = 400;
            while (a <= 420)
            {
                Console.Write(a + ", ");
                a += 2;
            }
            Console.WriteLine();

            // Alternativ
            int aa = 400;
            int max = 420;
            while (aa <= max)
            {
                Console.Write(aa);
                if (aa < max) // only print comma if not the last value
                {
                    Console.Write(", ");
                }
                aa += 2;
            }
            Console.WriteLine();

            //2. talrække: 9, 81, 729, 6561, 59049, 531441, 4782969
            int b = 9;
            while (b <= 4782969)
            {
                Console.Write(b + ", ");
                b *= 9;
            }
            Console.WriteLine();

            //3. talrække: 1, 4, 5, 9, 14, 23, 37, 60, 97, 157, 254, 411
            int x = 1;
            int y = 4;
            int z;
            Console.Write(x + ", " + y);

            // 'i < 10' fordi der er 12 tal i rækken, men de først 2 er skrevet ud ovenover
            for (int i = 0; i < 10; i++)
            {
                //lægger de sidste 2 tal sammen og udskriver
                z = x + y;
                Console.Write(", " + z);
                // Ændre x, y til nye værdier (rykke "et hak" op)
                x = y;
                y = z;
            }
            
            Console.ReadLine();
        }
    }
}
