namespace Obsthandel
{
    public class Artikel
    {
        private int id;
        private string bezeichnung;
        private double preis;

        public int Id { get => id; set => id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Preis { get => preis; set => preis = value; }

        public Artikel(int pid, string pbezeichnung, double ppreis)
        {
            Id = pid;
            Bezeichnung = pbezeichnung;
            Preis = ppreis;
        }
    }
}