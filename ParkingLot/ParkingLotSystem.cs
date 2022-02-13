using System;
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
            if (hasFreeSpot())
            {
                return parkingEntryPoint.CheckIn(customer);
            }
            else
            {
                throw new System.Exception("No free places for parking");
            }
        }

        private bool hasFreeSpot()
        {
            foreach (var floor in floors)
            {
                if (floor.HasFreePlaces())
                {
                    return true;
                }
            }
            return false;
        }

        public void FinishParking(ParkingExitPoint exitPoint, Customer customer)
        {
            exitPoint.PayForParking(customer.Ticket);
        }
    }
}