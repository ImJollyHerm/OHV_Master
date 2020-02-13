namespace Obsthandel
{
    public class Kunde
    {
        private int kundenID;
        private string vorname;
        private string nachname;
        private string strasse;
        private string pLZ;

        public int KundenID { get => kundenID; set => kundenID = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string PLZ { get => pLZ; set => pLZ = value; }

        public Kunde(int id, string vorn, string nachn, string strasse, string plz)
        {
            KundenID = id;
            Vorname = vorn;
            Nachname = nachn;
            Strasse = strasse;
            PLZ = plz;
        }
    }
}