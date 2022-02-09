
namespace OopDesigns.LibraryManagementSystem
{
    public class ManagementSystem
    {
        private IRepository<Member, string> memberRepository;
        private IRepository<Book, string> bookRepository;

        public void run()
        {
            greetings();
        }

        private void greetings()
        {
            displayMessage("Hi! Welcome to the library system!");
            displayMessage("Enter your login or your barcode: ");
            displayMessage("If you are a new user, write 'sign up' to sign up");
            string userInput = System.Console.ReadLine();
            Member member = memberRepository.Get(userInput);
        }



        private void displayMessage(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}