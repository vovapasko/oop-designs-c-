using System.Linq;

namespace OopDesigns.ParkingLot
{
    public class SystemEntryPoint
    {
        private PaymentSystem paymentSystem;
        private Customer customer;
        private ParkingLotSystem parkingLotSystem;

        public void Run()
        {
            parkingUseCase();
        }

        private void parkingUseCase()
        {
            var ticket = parkingLotSystem.StartParking(parkingLotSystem.EntryPoints.First(), customer);
            customer.Ticket = ticket;
            Invoice invoice = parkingLotSystem.FinishParking(parkingLotSystem.ExitPoints.First(), customer);
            customer.PayCard(invoice);
        }
    }
}