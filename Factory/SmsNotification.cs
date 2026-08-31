namespace Factory;

// Concrete product created when the factory receives the Sms option.
public sealed class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}
