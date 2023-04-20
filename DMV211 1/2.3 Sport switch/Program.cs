using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sport_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad er din alder? ");
            int alder = Convert.ToInt32(Console.ReadLine());
            string gruppe = AldersGruppe(alder);

            Console.WriteLine("Alderen {0} tilhører aldersgruppen {1}", alder, gruppe);
            Console.ReadLine();
        }

        public static string AldersGruppe(int alder)
        {
            string gruppe = "";

            switch (alder)
            {
                case int n when n < 14:
                    gruppe = "drenge";
                    break;

                case int n when n >= 14 && n < 16:
                    gruppe = "junior";
                    break;

                case int n when n >= 16 && n < 18:
                    gruppe = "ynglinge";
                    break;

                case int n when n >= 18:
                    gruppe = "senior";
                    break;

                default:
                    gruppe = "ikke valid";
                    break;
            }
            return gruppe;
        }
    }
}
