namespace OopDesigns.ParkingLot
{
    public abstract class Invoice
    {
        public float ToPay { get; set; }
        public PaymentStatus Status { get; set; }
    }
}