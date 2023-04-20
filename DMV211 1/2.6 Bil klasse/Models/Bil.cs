using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Bil_klasse.Models
{
    public class Bil
    {
        public Bil(int bilNr, string bilMaerke, double pris, int antal)
        {
            this.BilNr = bilNr;
            this.BilMærke = bilMaerke;
            this.Pris = pris;
            this.Antal = antal;
        }

        public int BilNr { get; set; }
        public string BilMærke { get; set; }
        public double Pris { get; set; }
        public int Antal { get; set; }

        public double PrisAendring(double procent)
        {
            double stigning = 0;

            stigning = Pris * procent / 100;

            if (stigning > 500)
            {
                return Pris + stigning;
            }
            return Pris;
        }
    }
}
