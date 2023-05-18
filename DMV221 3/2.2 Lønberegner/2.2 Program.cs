using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Lønberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Static method for tax calculations with a net pay return double value
        /// </summary>
        /// <param name="antalTimer"></param>
        /// <param name="timeLøn"></param>
        /// <param name="fradrag"></param>
        /// <param name="skatteProcent"></param>
        /// <returns></returns>
        private static double BeregnLoen(double antalTimer, double timeLøn, double fradrag, double skatteProcent)
        {
            var bruttoLøn = antalTimer * timeLøn;

            var amBidrag = bruttoLøn * 0.08;

            var LønUdenAMBidrag = bruttoLøn - amBidrag;

            var LønUdenFradrag = LønUdenAMBidrag - fradrag;

            var skat = skatteProcent * LønUdenFradrag / 100;

            // If the question is answered to the letter:
            var nettoløn = LønUdenFradrag - skat;
            // If the correct danish tax process is followed:
            //var nettoløn = LønUdenAMBidrag - skat;

            return nettoløn;
        }
    }
}