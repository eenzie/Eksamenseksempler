using System;

namespace _2._2_Iterationer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = EnterValidNumber();

            if (enteredNumber != -1)
            {
                Console.WriteLine("Det indtastede tal er: " + enteredNumber);
            }

            Console.ReadLine();
        }

        public static int EnterValidNumber()
        {
            int number = 0; // Assign an initial value

            bool isValidNumber = false;

            while (!isValidNumber)
            {
                Console.Write("Indtast et tal mellem 1 og 500 (eller -1 for at afslutte): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number == -1)
                    {
                        Console.WriteLine("Programmet er blevet afbrudt.");
                        return -1; // Terminate the method
                    }
                    else if (number >= 1 && number <= 500)
                    {
                        isValidNumber = true;
                    }
                }

                if (!isValidNumber)
                {
                    Console.WriteLine("Ugyldigt tal. Prøv igen.");
                }
            }

            return number;
        }
    }
}

