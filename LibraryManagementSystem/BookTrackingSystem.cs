using System;
using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    public abstract class BookTrackingSystem : BookSearchEngine
    {
        public Dictionary<Member, List<BookItem>> memberBooksDictionary { get; }
        public Dictionary<BookItem, Member> booksMemberDictionary { get; }

        public List<Book> Books { get; }
        private List<BookReservation> reservations;
        private List<BookCheckout> checkouts;
        public void AddCheckout(BookCheckout newCheckout)
        {
            checkouts.Add(newCheckout);
            try
            {
                var booksByMember = memberBooksDictionary[newCheckout.Member];
                booksByMember.Add(newCheckout.BookItem);
            }
            catch (System.ArgumentNullException)
            {
                var booksList = new List<BookItem>();
                booksList.Add(newCheckout.BookItem);
                memberBooksDictionary.Add(newCheckout.Member, booksList);
            }
            booksMemberDictionary.Add(newCheckout.BookItem, newCheckout.Member);
        }
        public void AddReservation(BookReservation newReservation)
        {
            reservations.Add(newReservation);
        }
        public List<BookItem> FetchBooksByMember(Member member)
        {
            return memberBooksDictionary[member];
        }
        public Member fetchMemberByBookItem(BookItem bookItem)
        {
            return booksMemberDictionary[bookItem];
        }
        public void AddBook(Book newBook)
        {
            Books.Add(newBook);
        }

        public abstract List<Book> GetBySubject(string subject);
        public abstract List<Book> GetByAuthor(string author);
        public abstract List<Book> GetByTitle(string title);
        public abstract List<Book> GetByPublicationDate(DateTime publicationDate);
    }
}