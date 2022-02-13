using System;
namespace OopDesigns.ParkingLot
{
    public class ParkingTicket
    {
        public DateTime DateIssued { get; }
        public string Id { get; }
        public Customer IssuedTo { get; }
        public AdditionalInfo metainformation { get; }
        public PaymentStatus Status { get; set; }
    }
}