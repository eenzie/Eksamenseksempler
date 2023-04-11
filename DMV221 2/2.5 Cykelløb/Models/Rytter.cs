using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Cykelløb.Models
{
    public class Rytter
    {
        /// <summary>
        /// Parameters, contructor for the class
        /// </summary>
        public Rytter(int nummer, string navn, double tid)
        {
            this.Nummer = nummer;
            this.Navn = navn;
            this.Tid = tid;
        }
        public int Nummer { get; set; }
        public string Navn { get; set; }
        public double Tid { get; set; }
    }
}
