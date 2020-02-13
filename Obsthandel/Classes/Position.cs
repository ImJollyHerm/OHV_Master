namespace Obsthandel
{
    public  class Position
    {
        private int posID;
        private int orderID;
        private int artID;
        private int menge;

        public int PosID { get => posID; set => posID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public int ArtID { get => artID; set => artID = value; }
        public int Menge { get => menge; set => menge = value; }

        public Position (int pPosId, int pOrderId, int pArtId, int pMenge)
        {
            posID = pPosId;
            orderID = pOrderId;
            artID = pArtId;
            menge = pMenge;
        }
    }
}