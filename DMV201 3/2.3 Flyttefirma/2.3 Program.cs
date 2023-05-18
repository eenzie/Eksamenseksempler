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

            Console.WriteLine("Indtast antal timer: ");


            Console.WriteLine("Indtast antal møbler tungere end 30kg: ");
            double flyttePris = 0;
            bool errorCheck = true;
            while (errorCheck)
            {
                try
                {
                    // Calls the method with required parameters for hours and heavy items
                    flyttePris = Services.FlyttePris2.CalculateRemovalPrice(9, -3);
                    errorCheck = false;
                    // Prints result to console using local culture currency
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    errorCheck = true;
                }
            }

            Console.WriteLine($"Pris for flytning: {flyttePris.ToString("C")}");
            Console.ReadLine();
        }
    }
}
