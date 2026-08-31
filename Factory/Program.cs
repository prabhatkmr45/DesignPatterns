namespace Factory;

class Program
{
    static void Main()
    {
        NotificationType[] requestedNotifications =
        [
            NotificationType.Email,
            NotificationType.Sms,
            NotificationType.Push
        ];

        foreach (NotificationType type in requestedNotifications)
        {
            INotification notification = NotificationFactory.Create(type);
            notification.Send("Your order has been shipped.");
        }
    }
}
