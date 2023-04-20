using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Sælgere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a two-dimensional array with sales data for two salespeople
            int[,] salgstal = new int[,]
                    {
                        { 187, 183, 196, 820, 185 },
                        { 174, 210, 115, 320, 120 }
                    };

            // Call the Beregn method with the sales array and two out parameters to store the sales totals
            int salg1, salg2;
            Beregn(salgstal, out salg1, out salg2);

            // Output the sales totals for each salesperson
            Console.WriteLine($"Sælger 1 solgte for {salg1} kr.");
            Console.WriteLine($"Sælger 2 solgte for {salg2} kr.");

            Console.ReadLine();
        }

        static void Beregn(int[,] salgstal, out int salg1, out int salg2)
        {
            // Initialize both sales totals to 0
            salg1 = 0;
            salg2 = 0;

            // Loop through each column in the sales array
            for (int søjle = 0; søjle < 5; søjle++)
            {
                // Add the current column's value to the first sales total, then the second sales total
                salg1 += salgstal[0, søjle];
                salg2 += salgstal[1, søjle];
            }
        }
    }
}
