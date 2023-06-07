namespace _2._6_Klasser.Models
{
    internal class Album
    {
        public int ISBN { get; }
        public int Udgivelsesår { get; set; }
        public string Titel { get; set; }
        public string TegnerNavn { get; set; }
        public int Oplag { get; set; }
        public double Pris { get; set; }

        public Album(int isbn, int udgivelsesår, string titel, string tegnerNavn, int oplag, double pris)
        {
            this.ISBN = isbn;
            this.Udgivelsesår = udgivelsesår;
            this.Titel = titel;
            this.TegnerNavn = tegnerNavn;
            this.Oplag = oplag;
            this.Pris = pris;
        }
    }
}
