using System;
namespace OopDesigns.LibraryManagementSystem
{
    public class BookCheckout
    {
        public string CheckoutId { get; }
        public BookItem BookItem { get; }
        public Member Member { get; }
        public DateTime DateIssued { get; }

        public BookCheckout(BookItem bookItem, Member member)
        {
            this.CheckoutId = Helper.GenerateUuid();
            this.BookItem = bookItem;
            this.Member = member;
            this.DateIssued = System.DateTime.Now;
        }
    }
}