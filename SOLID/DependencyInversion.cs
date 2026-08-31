namespace SOLID.DependencyInversion;

public interface IMessageSender
{
    void Send(string message);
}

public sealed class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"DIP: Email sent: {message}");
}

public sealed class NotificationService(IMessageSender sender)
{
    public void Notify(string message) => sender.Send(message);
}

public static class DependencyInversionDemo
{
    public static void Run()
    {
        IMessageSender sender = new EmailSender();
        new NotificationService(sender).Notify("Order completed.");
    }
}
