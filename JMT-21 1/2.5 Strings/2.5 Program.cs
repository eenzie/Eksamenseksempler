using System;

namespace _2._5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "abc";
            string input2 = "123";
            string mergedString = FletteToStrenge(input1, input2);
            Console.WriteLine(mergedString);

            string input3 = "Bambi";
            string input4 = "Leo the Lion";
            mergedString = FletteToStrenge(input3, input4);
            Console.WriteLine(mergedString);
            Console.ReadLine();
        }

        static string FletteToStrenge(string input1, string input2)
        {
            int length1 = input1.Length;
            int length2 = input2.Length;
            int maxLength = Math.Max(length1, length2);

            string mergedString = "";

            for (int i = 0; i < maxLength; i++)
            {
                if (i < length1)
                {
                    mergedString += input1[i];
                }

                if (i < length2)
                {
                    mergedString += input2[i];
                }
            }

            return mergedString;
        }
    }
}
