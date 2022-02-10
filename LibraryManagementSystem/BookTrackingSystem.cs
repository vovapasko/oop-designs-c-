using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    public class BookTrackingSystem
    {
        private Dictionary<Member, List<BookItem>> memberBooksDictionary;
        private Dictionary<BookItem, Member> booksMemberDictionary;
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
        public List<BookItem> FetchBooksByMember(Member member)
        {
            return memberBooksDictionary[member];
        }
        public Member fetchMemberByBookItem(BookItem bookItem)
        {
            return booksMemberDictionary[bookItem];
        }
    }
}