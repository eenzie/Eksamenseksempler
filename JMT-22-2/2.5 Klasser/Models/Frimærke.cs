using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Klasser.Models
{
    internal class Frimærke
    {
        public string Motivtekst { get ; set; }
        public double Beløb { get; set; }
        public bool Miniark { get; set; }

        public Frimærke()
        {
            this.Motivtekst = "dummy";
            this.Beløb = 0.00;
            this.Miniark = false;
        }

        public Frimærke(string motivtekst, double beløb, bool miniark)
        {
            this.Motivtekst = motivtekst;
            this.Beløb = beløb;
            this.Miniark = miniark;
        }

        public static void MotivÆndring(List<Frimærke> frimærker, string change, int index)
        {
            if (index >= 0 && index < frimærker.Count)
            {
                frimærker[index].Motivtekst = change;
            }
        }

        public static void BeløbÆndring(List<Frimærke> frimærker, double change, int index)
        {
            if (index >= 0 && index < frimærker.Count)
            {
                frimærker[index].Beløb += change;
            }
        }

        public static void MiniarkÆndring(List<Frimærke> frimærker, bool change, int index)
        {
            if (index >= 0 && index < frimærker.Count)
            {
                frimærker[index].Miniark = change;
            }
        }
    }
}
