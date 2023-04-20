using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Switch_Award
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast point: ");
            int point = Convert.ToInt32(Console.ReadLine());
            string rating = Award(point);

            Console.WriteLine("{0} point svarer til rating: {1}", point, rating);
            Console.ReadLine();
        }

        private static string Award(int num)
        {
            string rating = "";

            switch (num)
            {
                case int x when x > 0 && x <= 100:
                    rating = "Novice";
                    break;

                case int x when x > 100 && x <= 200:
                    rating = "Average";
                    break;

                case int x when x > 200:
                    rating = "Master";
                    break;

                default:
                    rating = "Unknown";
                    break;
            }
            return rating;
        }
    }
}
