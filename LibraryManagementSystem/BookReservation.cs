namespace OopDesigns.LibraryManagementSystem
{
    public class BookReservation
    {
        public string ReservationId { get; }
        public Book Book { get; }
        public Member Member { get; }

        public BookReservation(Book book, Member member)
        {
            this.ReservationId = Helper.GenerateUuid();
            this.Book = book;
            this.Member = member;
        }
    }
}