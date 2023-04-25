using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Barn_Klasse.Models
{
    public class Barn
    {
        public int Nr { get; set; }
        public string Navn { get; set; }
        public double Vægt { get; set; }

        public Barn(int nr, string fornavn, string efternavn, double vægt) 
        { 
            this.Nr = nr;
            this.Navn = fornavn + " " + efternavn;
            this.Vægt = vægt;
        }
    }
}
