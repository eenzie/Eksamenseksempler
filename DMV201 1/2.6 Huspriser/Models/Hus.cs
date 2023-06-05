using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Huspriser.Models
{
    internal class Hus
    {
        public int HusNr { get; set; }
        public string VejNavn { get; set; }
        public double Pris { get; set; }

        public Hus(int husNr, string vejNavn, double pris)
        {
            this.HusNr = husNr;
            this.VejNavn = vejNavn;
            this.Pris = pris;
        }

        /// <summary>
        /// Changes the price of a specified item in the collection
        /// </summary>
        /// <param name="huse"></param>
        /// <param name="change"></param>
        /// <param name="index"></param>
        public static void PrisAendring(List<Hus> huse, double change, int index)
        {
            if (index >= 0 && index < huse.Count)
            {
                huse[index].Pris += change;
            }
        }

        /// <summary>
        /// Finds the cheapest house in the collection
        /// </summary>
        /// <param name="huse"></param>
        /// <returns>The cheapest house (model)</returns>
        public static Hus HentBilligsteHus(List<Hus> huse)
        {
            var billigsteHus = huse.OrderBy(x => x.Pris).FirstOrDefault();
            return billigsteHus;
        }
    }
}
