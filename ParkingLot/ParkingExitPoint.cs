using System;
namespace OopDesigns.ParkingLot
{
    public class ParkingExitPoint : IProducerInvoice, IPayable
    {
        public Invoice ProduceInvoice(ParkingTicket ticket)
        {
            throw new NotImplementedException();
        }
        public ParkingTicket PayForParking(ParkingTicket ticket)
        {
            Invoice invoice = ProduceInvoice(ticket);
            var status = ticket.IssuedTo.PayCard(invoice);
            if (status)
            {
                ticket.Status = PaymentStatus.PAID;
                return ticket;
            }
            throw new System.Exception("Payment was wrong");
        }
    }
}