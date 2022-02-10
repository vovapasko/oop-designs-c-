using System;
namespace OopDesigns.LibraryManagementSystem
{
    public class Book
    {
        public Book()
        {
            BookId = Helper.GenerateUuid();
        }

        public Book(string iSBN, string title, string subject, DateTime publishedDate)
        {
            BookId = Helper.GenerateUuid();
            ISBN = iSBN;
            Title = title;
            Subject = subject;
            PublishedDate = publishedDate;
        }
        public string BookId { get; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime PublishedDate { get; set; }

    }
}