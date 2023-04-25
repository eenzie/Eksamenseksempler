using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _2._4__Alternative_Lasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] strings = {"Per", "Ib", "Grete", "Alexander", "007" };
            
            // Call to method
            Sorter(strings);

            Console.ReadLine();
        }

        public static void Sorter(string[] stringArray)
        {
            var sortedList = stringArray.OrderBy(x => x.Length).ToList();
            foreach (string item in sortedList)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
