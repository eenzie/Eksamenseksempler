using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Rumfangsberegninger.Models
{
    internal class Vare
    {
        public Vare(int varenr, double længde, double bredde, double højde) 
        {
            this.VareNr = varenr;
            this.Længde = længde;
            this.Bredde = bredde;
            this.Højde = højde;
        }
        public int VareNr { get; set; }
        public double Længde { get; set; }
        public double Bredde { get; set; }
        public double Højde { get; set; }

        public double BeregnRumfang()
        {
            return Længde * Bredde * Højde;
        }
    }
}
