namespace Factory;

// Concrete product created when the factory receives the Push option.
public sealed class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent: {message}");
    }
}
