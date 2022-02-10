using System;
using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    public interface BookSearchEngine
    {
        List<Book> GetBySubject(string subject);
        List<Book> GetByAuthor(string author);
        List<Book> GetByTitle(string title);
        List<Book> GetByPublicationDate(DateTime publicationDate);
    }
}