namespace OopDesigns.ParkingLot
{
    public interface IPayable
    {
        ParkingTicket PayForParking(ParkingTicket ticket);
    }
}