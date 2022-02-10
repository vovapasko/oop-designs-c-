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
        public BookStatus Status { get; set; }
    }
}