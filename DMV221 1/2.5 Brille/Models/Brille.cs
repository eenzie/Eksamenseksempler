using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_Brille_Rabat.Models
{
    internal class Brille
    {
        /// <summary>
        /// Brille class
        /// Parameters, contructor and instance method for calcualting discount price
        /// </summary>
        public Brille(int varenr, string brilleNavn, double salgspris, int antal)
        {
            this.VareNr = varenr;
            this.BrilleNavn = brilleNavn;
            this.SalgsPris = salgspris;
            this.Antal = antal;
        }
        public int VareNr { get; set; }
        public string BrilleNavn { get; set; }
        public double SalgsPris { get; set; }
        public int Antal { get; set; }

        /// <summary>
        /// Discount Method
        /// </summary>
        /// <returns>Discounted sales price</returns>
        public double RabatPris()
        {
            //if (SalgsPris >= 1000 && Antal > 1)
            //{
            //    var rabat = (double)SalgsPris * 0.05;
            //    var rabatPris = SalgsPris - rabat;
            //    return rabatPris;
            //}
            //if (SalgsPris >= 1000 && Antal == 1)
            //{
            //    var rabat = SalgsPris * 0.5;
            //    var rabatPris = SalgsPris - rabat;
            //    return rabatPris;
            //}
            //else
            //{
            //    return SalgsPris;
            //}

            if (SalgsPris > 1000)
            {
                if (Antal == 1)
                {
                    return SalgsPris * 0.5;
                }
                return SalgsPris * 0.95; //also 5% discount, just the other way around
            }
            return SalgsPris;
        }
    }
}
