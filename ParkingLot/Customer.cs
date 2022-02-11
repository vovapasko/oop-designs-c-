namespace OopDesigns.ParkingLot
{
    public class Customer
    {
        public Vehicle Vehicle { get; }
        public Wallet Wallet { get; }
        public ParkingTicket Ticket { get; set; }

        public bool PayCash(Invoice invoice)
        {
            return true;
        }

        public bool PayCard(Invoice invoice)
        {
            return true;
        }
    }
}