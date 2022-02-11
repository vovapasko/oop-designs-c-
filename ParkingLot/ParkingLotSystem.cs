using System.Collections.Generic;
namespace OopDesigns.ParkingLot
{
    public abstract class ParkingLotSystem
    {
        public List<ParkingEntryPoint> EntryPoints;
        public List<ParkingExitPoint> ExitPoints;
        private List<ParkingFloor> floors;

        public ParkingTicket StartParking(ParkingEntryPoint parkingEntryPoint, Customer customer)
        {
            return parkingEntryPoint.CheckIn(customer);
        }
        public Invoice FinishParking(ParkingExitPoint exitPoint, Customer customer)
        {
            return exitPoint.Checkout(customer.Ticket);
        }
    }
}