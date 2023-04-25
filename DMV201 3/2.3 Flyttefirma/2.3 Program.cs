using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Flyttefirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the method with required parameters for hours and heavy items
            var flyttePris = Services.FlyttePris2.CalculateRemovalPrice(9, 3);

            // Prints result to console using local culture currency
            Console.WriteLine($"Pris for flytning: {flyttePris.ToString("C")}");
            Console.ReadLine();
        }
    }
}
