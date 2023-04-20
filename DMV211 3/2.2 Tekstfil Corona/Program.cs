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

            var enDag = varighed.Where(x => x == 1).Count();
            var toDage = varighed.Where(x => x == 2).Count();
            var treDage = varighed.Where(x => x == 3).Count();
            var fireDage = varighed.Where(x => x == 4).Count();
            var femDage = varighed.Where(x => x == 5).Count();
            var seksDage = varighed.Where(x => x == 6).Count();
            var syvDage = varighed.Where(x => x == 7).Count();
            var otteDage = varighed.Where(x => x == 8).Count();
            var niDage = varighed.Where(x => x == 9).Count();
            var tiDage = varighed.Where(x => x == 10).Count();
            var overTiDage = varighed.Where(x => x >= 11).Count();
            var antalRegi = varighed.Count();
            var gennemsnit = varighed.Sum() / antalRegi;
            var maxDage = varighed.Max();

            string dataoutput = "";

            dataoutput += $"1 dag: {enDag}" + Environment.NewLine;
            dataoutput += $"2 dage: {toDage}" + Environment.NewLine;
            dataoutput += $"3 dage: {treDage}" + Environment.NewLine;
            dataoutput += $"4 dage: {fireDage}" + Environment.NewLine;
            dataoutput += $"5 dage: {femDage}" + Environment.NewLine;
            dataoutput += $"6 dage: {seksDage}" + Environment.NewLine;
            dataoutput += $"7 dage: {syvDage}" + Environment.NewLine;
            dataoutput += $"8 dage: {otteDage}" + Environment.NewLine;
            dataoutput += $"9 dage: {niDage}" + Environment.NewLine;
            dataoutput += $"10 dage: {tiDage}" + Environment.NewLine;
            dataoutput += $"Mere end 10 dage: {overTiDage}" + Environment.NewLine + Environment.NewLine;
            dataoutput += $"Antal registreringer: {antalRegi}" + Environment.NewLine + Environment.NewLine;
            dataoutput += $"Gennemsnit: {gennemsnit}" + Environment.NewLine + Environment.NewLine;
            dataoutput += $"Max dage: {maxDage}";

            System.IO.File.AppendAllText("overblik.txt", dataoutput);
            Console.Write("Resultaterne er skrevet til filen overblik.txt");
            Console.ReadLine();
        }
    }
}
