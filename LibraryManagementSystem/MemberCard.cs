namespace OopDesigns.LibraryManagementSystem
{
    public class MemberCard
    {
        string barcode { get; }
        public MemberCard()
        {
            barcode = generateBarcode();
        }

        private string generateBarcode()
        {
            return Helper.GenerateUuid();
        }
    }
}