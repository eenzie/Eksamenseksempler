using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfil_Corona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = System.IO.File.ReadAllLines("corona.txt").ToList();

            List<int> varighed = new List<int>();
            foreach (var item in data)
            {
                varighed.Add(Int32.Parse(item));
            }

            StringBuilder dataoutput = new StringBuilder();

            dataoutput.AppendLine($"1 dag: {varighed.Where(x => x == 1).Count()}");
            dataoutput.AppendLine($"2 dage: {varighed.Where(x => x == 2).Count()}");
            dataoutput.AppendLine($"3 dage: {varighed.Where(x => x == 3).Count()}");
            dataoutput.AppendLine($"4 dage: {varighed.Where(x => x == 4).Count()}");
            dataoutput.AppendLine($"5 dage: {varighed.Where(x => x == 5).Count()}");
            dataoutput.AppendLine($"6 dage: {varighed.Where(x => x == 6).Count()}");
            dataoutput.AppendLine($"7 dage: {varighed.Where(x => x == 7).Count()}");
            dataoutput.AppendLine($"8 dage: {varighed.Where(x => x == 8).Count()}");
            dataoutput.AppendLine($"9 dage: {varighed.Where(x => x == 9).Count()}");
            dataoutput.AppendLine($"10 dage: {varighed.Where(x => x == 10).Count()}");
            dataoutput.AppendLine($"Mere end 10 dage: {varighed.Where(x => x >= 11).Count()}");
            dataoutput.AppendLine($"Antal registreringer: {varighed.Count}");
            dataoutput.AppendLine($"Gennemsnit: {varighed.Sum() / varighed.Count()}");
            dataoutput.AppendLine($"Max dage: {varighed.Max()}");

            System.IO.File.AppendAllText("overblik.txt", dataoutput.ToString());
            Console.Write("Resultaterne er skrevet til filen overblik.txt");
            Console.ReadLine();
        }
    }
}
