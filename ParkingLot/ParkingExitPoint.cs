using System;
namespace OopDesigns.ParkingLot
{
    public class ParkingExitPoint : IProducerInvoice
    {
        public Invoice ProduceInvoice(ParkingTicket ticket)
        {
            throw new NotImplementedException();
        }
        public void FinishParking(ParkingTicket ticket)
        {
            Invoice invoice = ProduceInvoice(ticket);
            var status = ticket.IssuedTo.PayCard(invoice);
            if (status)
            {
                ticket.Status = PaymentStatus.PAID;
                return;
            }
            throw new System.Exception("Payment was wrong");
        }
    }
}