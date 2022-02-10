namespace OopDesigns.LibraryManagementSystem
{
    public abstract class NotificationService
    {
        public abstract bool SendNotificationBookAvailable(BookReservation reservation);
        public abstract bool SendNotificationDateOverdue(BookCheckout bookCheckout);


    }
}