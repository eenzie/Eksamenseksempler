using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Pulstal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabel = { 187, 183, 196, 182, 185, 194, 190, 189, 188 };

            int gennemsnitsPuls = 0;
            int pulsMinMaxForskel = 0;

            gennemsnitsPuls = Analyze(tabel, out pulsMinMaxForskel);

            Console.WriteLine($"Gennemsnitspulsen er: {gennemsnitsPuls}");
            Console.WriteLine($"Forskellen på minimum og maximum puls er: {pulsMinMaxForskel}");
            Console.ReadLine();
        }

        private static int Analyze(int[] array, out int difference)
        {
            int result = array.Sum() / array.Count();
            difference = array.Max() - array.Min();
            return result;
        }
    }
}
