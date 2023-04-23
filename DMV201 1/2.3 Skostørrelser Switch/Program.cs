using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Skostørrelser_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your shoe size (40-46):");
            int euSize = Convert.ToInt32(Console.ReadLine());
            double ukSize = SizeConverter(euSize);

            Console.WriteLine("EU size {0} converts to UK size {1}", euSize, ukSize);
            Console.ReadLine();
        }

        public static double SizeConverter(int euSize)
        {
            double ukSize = 0;

            switch (euSize)
            {
                case 40:
                    ukSize = 7;
                    break;

                case 41:
                    ukSize = 7.5;
                    break;

                case 42:
                    ukSize = 8.5;
                    break;

                case 43:
                    ukSize = 9.5;
                    break;

                case 44:
                    ukSize = 10;
                    break;
                case 45:
                    ukSize = 11;
                    break;

                default:
                    ukSize = -1;
                    break;
            }
            return ukSize;
        }
    }
}
