﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Klasser_Laptop.Models
{
    internal class Laptop
    {
        public Laptop(string navn = "no name", string processor = "none", double beløb = 0.00)
        {
            this.Navn = navn;
            this.Processor = processor;
            this.Beløb = beløb;
        }

        public string Navn { get; set; }
        public string Processor { get; set; }
        public double Beløb { get; set; }
    }
}
