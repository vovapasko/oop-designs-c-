
namespace OopDesigns.LibraryManagementSystem
{
    public class ManagementSystem
    {
        private IRepository<Member, string> memberRepository;
        private BookSearchEngine bookRepository;

        public void run()
        {
            greetings();
        }

        private void greetings()
        {
        }



        private void displayMessage(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}