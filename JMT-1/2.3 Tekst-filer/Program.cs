using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Tekst_filer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[25];
            Random random = new Random();

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = random.Next(20, 150);
            }

            RandomNumber(index);

            Console.WriteLine("Result written to text file 'randomtal.txt'");
            Console.ReadLine();
        }

        //public static void RandomNumber(int[] array)
        //{
        //    var dataoutput = "";

        //    foreach (int i in array)
        //    {
        //        dataoutput += $"{i}, ";
        //    }

        //    System.IO.File.WriteAllText("randomtal.txt", dataoutput);
        //}

        public static void RandomNumber(int[] array)
        {
            // Format the output string with comma-separated values
            var dataOutput = string.Join(", ", array);

            // Write the formatted string to a file
            System.IO.File.WriteAllText("randomtal.txt", dataOutput);
        }
    }
}
