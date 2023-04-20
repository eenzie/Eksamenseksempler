using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Hus_klasse.Models
{
    public class Hus
    {
        public Hus(int husNr, string adresse, int postNr, string byNavn, int størrelse, int badeværelser) 
        { 
            this.HusNr = husNr;
            this.Adresse = adresse;
            this.PostNr = postNr;
            this.ByNavn = byNavn;
            this.Størrelse = størrelse;
            this.Badeværelser = badeværelser;
        }

        public int HusNr { get; set; }
        public string Adresse { get; set; }
        public int PostNr { get; set; }
        public string ByNavn { get; set;}
        public double Størrelse { get; set; }
        public int Badeværelser { get; set; }

        public double BeregnPris(int postNr, int badeværelser)
        {
            double result = 0;

            if (postNr == 7100 && badeværelser >= 2)
            {
                result = Størrelse * 15000 * 1.1;
            }
            if (postNr != 7100 && badeværelser >=2)
                        {
                result = Størrelse * 13000 * 1.1;
            }
            if (postNr != 7100 && badeværelser <= 2)
            {
                result = Størrelse * 13000;
            }
            return result;
        }
    }
}
