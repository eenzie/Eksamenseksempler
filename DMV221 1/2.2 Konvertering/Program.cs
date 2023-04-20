using System;

namespace _2._2_Konvertering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter your size (XS, S, M, L, XL): ");
                string size = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("Convert to EU or US? ");
                string system = Console.ReadLine().Trim().ToLower();

                string convert = SizeConverter(size, system);

                Console.WriteLine("Size {0} = size {1} ", size.ToUpper(), convert);
                Console.ReadLine();
            }
        }

        public static string SizeConverter(string size, string system)
        {
            int convertedSize = -1;

            switch (size)
            {
                case "xs":
                    convertedSize = system == "eu" ? 34 : 2;
                    break;

                case "s":
                    convertedSize = system == "eu" ? 36 : 4;
                    break;

                case "m":
                    convertedSize = system == "eu" ? 38 : 6;
                    break;

                case "l":
                    convertedSize = system == "eu" ? 40 : 8;
                    break;

                case "xl":
                    convertedSize = system == "eu" ? 42 : 10;
                    break;

                default:
                    convertedSize = -1;
                    break;
            }
            return convertedSize.ToString();
        }

    }
}

