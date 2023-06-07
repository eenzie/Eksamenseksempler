using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabel = { 2, 3, 4, 3, 7, 9, 8, 3, 8, 1, 7, 9, 3, 6, 8, 9, 8, 1 };

            var etTal = 0;
            var otteTal = 0;
            etTal = Antal(tabel, out otteTal);

            Console.WriteLine($"Der er {etTal} et-taller og {otteTal} otte-taller");
            Console.ReadLine();
        }

        static int Antal(int[] tabel, out int otteTal)
        {
            int etTal = tabel.Count(x => x == 1);
            otteTal = tabel.Count(y => y == 8);

            return etTal;
        }
    }
}
