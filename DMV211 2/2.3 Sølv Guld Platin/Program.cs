using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sølv_Guld_Platin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast kundeomsætning: ");
            int omsætning = Convert.ToInt32(Console.ReadLine());
            string kundeType = Kundetype(omsætning);

            Console.WriteLine("Kundeomsætning {0} svare til kundetypen: {1}", omsætning, kundeType);
            Console.ReadLine();
        }

        private static string Kundetype (int num)
        {
            string kundeType = "";

            switch (num)
            {
                case int x when x > 0 && x <= 100000:
                    kundeType = "Sølv";
                    break;

                case int x when x > 100000 && x <= 500000:
                    kundeType = "Guld";
                    break;

                case int x when x > 500000:
                    kundeType = "Platin";
                    break;

                default:
                    kundeType = "kundetype ukendt";
                    break;
            }
            return kundeType;
        }
    }
}
