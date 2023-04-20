using _2._5_Klasser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> laptops = new List<Laptop>();

            laptops.Add(new Laptop("Acer Swift 3", "Ryzen 5 4500U", 11899.00));
            laptops.Add(new Laptop("Dell XPS 13", "Core i7 1185G7", 9799.00));
            laptops.Add(new Laptop());

            foreach (var laptop in laptops)
            {
                //Console.WriteLine("Navn: " + laptop.Navn + ". Processor: " + laptop.Processor + ". Beløb: " + laptop.Beløb);
                Console.WriteLine($"Navn: {laptop.Navn}, Processor: {laptop.Processor}, Beløb: {laptop.Beløb.ToString("0.00")}kr.");
            }
            Console.ReadLine();
        }
    }
}
