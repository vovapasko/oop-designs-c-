namespace OopDesigns.LibraryManagementSystem
{
    public class Profile
    {
        public Profile(string name)
        {
            Name = name;
        }

        public Profile(string name, string address, string email, string phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        string Name { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}