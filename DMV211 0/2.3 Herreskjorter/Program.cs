using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Herreskjorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your neck size (37-48):");
            int neckSize = Convert.ToInt32(Console.ReadLine());
            string size = SizeConverter(neckSize);

            Console.WriteLine("Neck size {0} converts to size {1}", neckSize, size);
            Console.ReadLine();
        }

        public static string SizeConverter(int neckSize)
        {
            string size = "";

            switch (neckSize)
            {
                case 37:
                case 38:
                    size = "S";
                    break;

                case 39:
                case 40:
                    size = "M";
                    break;

                case 41:
                case 42:
                    size = "L";
                    break;

                case 43:
                case 44:
                    size = "XL";
                    break;

                case 45:
                case 46:
                    size = "XXL";
                    break;

                case 48:
                    size = "XXXL";
                    break;

                default:
                    size = "";
                    break;
            }
            return size;
        }
    }
}
