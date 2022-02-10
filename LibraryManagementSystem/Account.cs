namespace OopDesigns.LibraryManagementSystem
{
    public abstract class Account
    {
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}