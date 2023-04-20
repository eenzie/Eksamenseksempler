using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._6_Bil_klasse.Models;

namespace _2._6_Bil_klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bil> biler = new List<Bil>();

            biler.Add(new Bil(1, "Audi", 400000, 3));
            biler.Add(new Bil(2, "Skoda", 40000, 3));
            biler.Add(new Bil(3, "Opel", 30000, 3));
            biler.Add(new Bil(4, "Mercedes", 800000, 3));

            Console.WriteLine("*** Original Priser ***");
            foreach (var item in biler)
            {
                Console.WriteLine($"Bil nr: {item.BilNr}, mærke: {item.BilMærke}, pris: {item.Pris}kr., antal: {item.Antal}stk");
            }
            Console.WriteLine();

            Console.WriteLine("*** Nye Priser ***");
            foreach (var item in biler)
            {
                var nySalgsPris = item.PrisAendring(1);
                Console.WriteLine($"Bil nr: {item.BilNr}, mærke: {item.BilMærke}, ny pris: {nySalgsPris}kr., antal: {item.Antal}stk");
            }

            Console.ReadLine();
        }
    }
}
