using System.Collections.Generic;
namespace OopDesigns.ParkingLot
{
    public class ParkingFloor
    {
        List<ParkingSpot> parkingSpots;
        private IPayable customersPortal;
        public bool HasFreePlaces()
        {
            return true;
        }
        public ParkingTicket PayForParking(Customer customer)
        {
            return customersPortal.PayForParking(customer.Ticket);
        }
    }
}