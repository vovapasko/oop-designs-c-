using System;
using System.Linq;
namespace OopDesigns.LibraryManagementSystem
{
    public class ManagementSystem
    {
        private AuthenticationSystem authenticationSystem { get; }
        private BookTrackingSystem bookTrackingSystem;
        private FineSystem fineSystem;
        public void Run()
        {
            System.Console.WriteLine("Entry point of app");
        }


        private void returnBookUseCase()
        {
            Member member = new Member("login", "password");
            var borrowedBooksList = member.CheckedOutBooks;
            BookItem returnedBook = member.ReturnBook(borrowedBooksList.First());
            var checkout = bookTrackingSystem.GetBookCheckout(returnedBook);
            if (checkoutOverdued(checkout))
            {
                fineSystem.ProvideFineInvoice(member);
            }
        }

        private bool checkoutOverdued(BookCheckout checkout)
        {
            throw new NotImplementedException();
        }
    }
}