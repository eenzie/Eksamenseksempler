using System;

namespace _2._5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string navn1 = "Jørgensen";
            string navn2 = "Puch";

            Console.WriteLine("Efternavne før ombytning:");
            Console.WriteLine("Navn1: " + navn1);
            Console.WriteLine("Navn2: " + navn2);

            Test(ref navn1, ref navn2);

            Console.WriteLine("Efternavne efter ombytning:");
            Console.WriteLine("Navn1: " + navn1);
            Console.WriteLine("Navn2: " + navn2);

            string tekst = "en To TrE fire æbler.";
            string resultat = UdenVokaler(tekst);
            Console.WriteLine("Tekst uden vokaler: " + resultat);

            Console.ReadLine();
        }

        static void Test(ref string navn1, ref string navn2)
        {
            if (navn2.CompareTo(navn1) > 0)
            {
                string temp = navn1;
                navn1 = navn2;
                navn2 = temp;
            }
        }

        static string UdenVokaler(string text)
        {
            char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å' };

            foreach (char vokal in vokaler)
            {
                text = text.Replace(vokal.ToString(), "");
            }

            return text;
        }
    }
}
