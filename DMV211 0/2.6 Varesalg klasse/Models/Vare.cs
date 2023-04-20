using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Varesalg_klasse.Models
{
    public class Vare
    {
        public Vare(int varenr, string vareNavn, double salgspris, int antal)
        {
            this.VareNr = varenr;
            this.VareNavn = vareNavn;
            this.SalgsPris = salgspris;
            this.Antal = antal;
        }
        public int VareNr { get; set; }
        public string VareNavn { get; set; }
        public double SalgsPris { get; set; }
        public int Antal { get; set; }


        public double PrisAendring(double procent)
        {
            return SalgsPris + (SalgsPris * procent / 100);
        }
    }
}
