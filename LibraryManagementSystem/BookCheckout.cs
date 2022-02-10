namespace OopDesigns.LibraryManagementSystem
{
    public class BookCheckout
    {
        public BookItem bookItem { get; }
        public Member member { get; }

        public BookCheckout(BookItem bookItem, Member member)
        {
            this.bookItem = bookItem;
            this.member = member;
        }
    }
}