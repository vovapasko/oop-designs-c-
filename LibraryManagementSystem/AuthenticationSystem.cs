using System.Reflection.Emit;
namespace OopDesigns.LibraryManagementSystem
{
    public abstract class AuthenticationSystem
    {
        private IRepository<Account, string> accountsRepository;
        public abstract Account Login(string login, string password);
        public abstract Account SignUp(string login, string passwrod);
    }
}