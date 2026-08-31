namespace Factory;

// Factory: centralizes concrete-object selection so callers do not invoke constructors.
public static class NotificationFactory
{
    public static INotification Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new EmailNotification(),
            NotificationType.Sms => new SmsNotification(),
            NotificationType.Push => new PushNotification(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported notification type.")
        };
    }
}
