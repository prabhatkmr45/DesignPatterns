namespace DependencyInjection;

// Concrete notification service registered as transient.
public sealed class EmailNotificationService : INotificationService
{
    public void SendOrderConfirmation(string orderId)
    {
        Console.WriteLine($"Email confirmation sent for order {orderId}.");
    }
}
