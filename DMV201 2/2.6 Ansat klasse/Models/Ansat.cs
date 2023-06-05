using System.Collections.Generic;
using System.Linq;

namespace _2._6_Ansat_klasse.Models
{
    public class Ansat
    {
        public int Nr { get; set; }
        public string Navn { get; set; }
        public double Maanedsloen { get; set; }

        public Ansat(int nr, string navn, double maanedsloen)
        {
            this.Nr = nr;
            this.Navn = navn;
            this.Maanedsloen = maanedsloen;
        }

        /// <summary>
        /// Ændrer lønninger på alle ansatte med et angivet beløb
        /// </summary>
        /// <param name="ansatte"></param>
        /// <param name="loenAendring"></param>
        public static void LoenAendring(List<Ansat> ansatte, double loenAendring)
        {
            foreach (Ansat ansat in ansatte)
            {
                ansat.Maanedsloen += loenAendring;
            }
        }

        /// <summary>
        /// Finder den laveste og højeste løn
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="maxLoen"></param>
        /// <returns>den laveste løn, og den højeste løn som 'out' parameter</returns>
        public static double FindMaxMin(List<Ansat> collection, out double maxLoen)
        {
            double minLoen = 0;
            maxLoen = 0;

            foreach (var item in collection)
            {
                minLoen = collection.Min(x => x.Maanedsloen);
                maxLoen = collection.Max(x => x.Maanedsloen);
            }
            return minLoen;
        }
    }
}
