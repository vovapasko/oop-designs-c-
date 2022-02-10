namespace OopDesigns.LibraryManagementSystem
{
    public class BookReservation
    {
        public string ReservationId { get; }
        public BookItem BookItem { get; }
        public Member Member { get; }

        public BookReservation(BookItem book, Member member)
        {
            this.ReservationId = Helper.GenerateUuid();
            this.BookItem = book;
            this.Member = member;
        }
    }
}