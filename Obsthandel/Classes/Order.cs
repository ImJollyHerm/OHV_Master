using System;

namespace Obsthandel
{
    public class Order
    {
        private int orderID;
        private string kundenID;
        private DateTime date;
        private double price;
        private bool paid;

        public int ID { get => orderID; set => orderID = value; }
        public string Kunde { get => kundenID; set => kundenID = value; }
        public DateTime Datum { get => date; set => date = value; }
        public double Preis { get => price; set => price = value; }
        public bool Bezahlt { get => paid; set => paid = value; }

        public Order(int ID, string pkunde, DateTime pdate, double pprice, bool ppaid)
        {
            orderID = ID;
            kundenID = pkunde;
            date = pdate;
            price = pprice;
            paid = ppaid;
        }
    }
}