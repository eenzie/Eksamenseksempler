using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Huspriser.Models
{
    internal class Hus
    {
        public Hus(int husNr, string vejNavn, double pris)
        {
            this.HusNr = husNr;
            this.VejNavn = vejNavn;
            this.Pris = pris;
        }

        public int HusNr { get; set; }
        public string VejNavn { get; set; }
        public double Pris { get; set; }

        public double PrisAendring(int procent)
        {
            double result = 0;
            result = Pris * procent / 100;

            return result;
        }
    }
}
