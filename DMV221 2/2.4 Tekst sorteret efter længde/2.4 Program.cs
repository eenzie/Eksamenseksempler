using System;

namespace _2._4_Tekst_sorteret_efter_længde
{
    internal class Program
    {
        /// <summary>
        /// Calls method to sort given array and prints to console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] ordListe = new string[] { "Bananer", "Gær", "Rugbrød", "Æg", "Mel", "Smør", "Sukker" };

            Sorter(ordListe);

            foreach (string item in ordListe)
            {
                Console.Write(item + "," + " ");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Method for sorting a string array by length of string
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Sorted array by length</returns>
        public static string[] Sorter(string[] array)
        {
            Array.Sort(array, (item1, item2) => item2.Length.CompareTo(item1.Length));
            return array;
        }
    }
}
