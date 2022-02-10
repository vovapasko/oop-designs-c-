using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    public interface BookSearchEngine
    {
        List<Book> GetBooks();
        List<Book> GetByAuthor();
        List<Book> GetByTitle();
        List<Book> GetByPublicationDate();
    }
}