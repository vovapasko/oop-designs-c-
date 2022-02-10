using System;
using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    public class Member : Account
    {
        public Member(string login, string password) : base(login, password)
        {
        }
        public List<BookItem> CheckedOutBooks { get; }
        public Profile profile { get; set; }
        public MemberCard memberCard { get; }
        private BookSearchEngine bookRepository;

        public List<Book> FindByTitle(string title)
        {
            return bookRepository.GetByTitle(title);
        }

        public List<Book> FindBySubject(string subject)
        {
            return bookRepository.GetBySubject(subject);
        }

        public List<Book> FindByAuthor(string author)
        {
            return bookRepository.GetByAuthor(author);
        }
        public List<Book> FindByPublicationDate(DateTime publicationDate)
        {
            return bookRepository.GetByPublicationDate(publicationDate);
        }

        public BookCheckout CheckoutBook(BookItem bookItem)
        {
            if (CheckedOutBooks.Count > Configs.MAX_DAYS_TO_LOAN)
            {
                throw new System.Exception("You have too many books loaned");
            }
            CheckedOutBooks.Add(bookItem);
            return new BookCheckout(bookItem, this);
        }

        public BookReservation ReserveBook(BookItem book)
        {
            return new BookReservation(book, this);
        }
        public BookItem ReturnBook(BookItem bookItem)
        {
            CheckedOutBooks.Remove(bookItem);
            return bookItem;
        }
    }
}