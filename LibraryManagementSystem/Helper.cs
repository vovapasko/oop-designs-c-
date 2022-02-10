namespace OopDesigns.LibraryManagementSystem
{
    public class Helper
    {
        public static string GenerateUuid()
        {
            return System.Guid.NewGuid().ToString();
        }
    }
}