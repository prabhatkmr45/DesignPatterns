namespace Factory;

public sealed class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent: {message}");
    }
}
