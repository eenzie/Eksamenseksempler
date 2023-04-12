using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Tekst_filer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> randomNumbers = new List<string>();


            //Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");

        }


        public static string RandomNumber()
        {
            var result = string.Empty;   // variable to hold the result
            Random randomNum = new Random();   // built in auto generator (algorithm) for random numbers

            while (result.Length <= 25)   // while loop to generate 9 numbers
            {
                var number = randomNum.Next(20, 150);   // temp variable that then 
                result += number.ToString();   // adds the value to the result

                //alternative
                // result += rnd.Next(1, 10).ToString();
            }
            return result;   // when done, result is returned

        }
    }
}
