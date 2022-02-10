namespace OopDesigns.LibraryManagementSystem
{
    public class BookReservation
    {
        public Book Book { get; }
        public Member Member { get; }

        public BookReservation(Book book, Member member)
        {
            this.Book = book;
            this.Member = member;
        }
    }
}