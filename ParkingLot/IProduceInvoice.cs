namespace OopDesigns.ParkingLot
{
    public interface IProducerInvoice
    {
        Invoice ProduceInvoice(ParkingTicket ticket);
    }
}