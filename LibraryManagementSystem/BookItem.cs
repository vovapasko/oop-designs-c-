namespace OopDesigns.LibraryManagementSystem
{
    public class BookItem : Book
    {
        public BookItem()
        {
            ItemId = Helper.GenerateUuid();
            Status = BookStatus.Available;
        }

        public string ItemId { get; }
        public string RackNumber { get; set; }
        public BookStatus Status { get; set; }
    }
}