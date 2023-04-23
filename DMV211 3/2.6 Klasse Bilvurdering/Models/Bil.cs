using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Klasse_Bilvurdering.Models
{
    public class Bil
    {
        public Bil(string regNr, double nyPris, int aarGang, int odometer, double stand, bool klima)
        {
            this.RegNr = regNr;
            this.NyPris = nyPris;
            this.Aargang = aarGang;
            this.Odometer = odometer;
            this.Stand = stand;
            this.Klima = klima;
        }
        public string RegNr { get; set; }
        public double NyPris { get; set; }
        public int Aargang { get; set; }
        public int Odometer { get; set; }
        public double Stand { get; set; }
        public bool Klima { get; set; }

        public double Vurdering()
        {
            double pris = NyPris;
            int Alder = DateTime.Now.Year - Aargang;

            pris *= Stand;

            if (Odometer > 25000)
            {
                pris *= 0.9;
            }
            if (Alder <= 1)
            {
                pris *= 0.8;
            }
            else if (Alder <= 3)
            {
                pris *= 0.6;
            }
            else
            {
                pris *= 0.35;
            }
            if (Klima)
            {
                pris += 5000;
            }
            return pris;
        }
    }
}
