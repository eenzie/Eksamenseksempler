namespace _2._6_Klasser.Models
{
    internal class Lampe
    {
        public int ProduktNummer { get; set; }
        public int Typekode { get; set; }
        public string Lampenavn { get; set; }
        public string Designernavn { get; set; }
        public string Producentnavn { get; set; }
        public double Pris { get; set; }

        public Lampe(int produktnummer, int typekode, string lampenavn, string designernavn, string producentnavn, double pris)
        {
            this.ProduktNummer = produktnummer;
            this.Typekode = typekode;
            this.Lampenavn = lampenavn;
            this.Designernavn = designernavn;
            this.Producentnavn = producentnavn;
            this.Pris = pris;
        }
    }
}
