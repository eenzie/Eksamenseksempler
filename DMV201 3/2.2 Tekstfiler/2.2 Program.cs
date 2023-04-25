using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Tekstfiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services.StatisticCalculator statisticCalculator = new Services.StatisticCalculator();  
            statisticCalculator.WriteStaticsFile();
        }
    }
}
