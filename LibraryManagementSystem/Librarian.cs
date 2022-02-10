namespace OopDesigns.LibraryManagementSystem
{
    public class Librarian : Account
    {
        public Librarian(string login, string password) : base(login, password)
        {
        }
        private BookTrackingSystem bookTrackingSystem;
        public void AddBook(Book book)
        {
            bookTrackingSystem.AddBook(book);
        }
        public void AddBookItem(BookItem bookItem)
        {
            bookTrackingSystem.AddBook(bookItem);
        }
        // here you can add also methods for tracking the members


    }
}