namespace OopDesigns.ParkingLot.ParkingSpots
{
    public class ElectroParkingSpot : ParkingSpot, IProducerInvoice
    {

        public ParkingTicket ChargeVehicle(ElectroCar electroCar)
        {
            electroCar.ChargingPercent = 100;
            var carOwner = electroCar.Owner;
            Invoice invoice = ProduceInvoice(carOwner.Ticket);
            var updatedTicket = addChargingToTicketPrice(carOwner.Ticket, invoice);
            return updatedTicket;
        }

        private ParkingTicket addChargingToTicketPrice(ParkingTicket ticket, Invoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public Invoice ProduceInvoice(ParkingTicket ticket)
        {
            throw new System.NotImplementedException();
        }
    }
}