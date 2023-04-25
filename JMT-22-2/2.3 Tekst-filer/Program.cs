using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Tekst_filer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int heltal = Heltal();
                UligeTal(heltal);

                Console.WriteLine("Tryk på en tast for at fortsætte eller Esc for at afslutte.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        public static int Heltal()
        {
            int heltal;
            bool erHeltal = false;
            do
            {
                Console.Write("Indtast et heltal: ");
                if (int.TryParse(Console.ReadLine(), out heltal))
                {
                    erHeltal = true;
                }
                else
                {
                    Console.WriteLine("Fejl: Ikke et gyldigt heltal. Prøv igen.");
                }
            } while (!erHeltal);
            return heltal;
        }

        public static void UligeTal(int heltal)
        {
            if (heltal % 2 != 0)
            {
                string textoutput = $"Ulige tal: {heltal.ToString()}" + Environment.NewLine;
                System.IO.File.AppendAllText("tal.txt", textoutput);
            }
        }
    }
}
