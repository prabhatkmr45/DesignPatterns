namespace Factory;

// Concrete product created when the factory receives the Email option.
public sealed class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}
