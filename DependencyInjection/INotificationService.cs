namespace DependencyInjection;

// Abstraction for outbound notifications, allowing implementations to be replaced.
public interface INotificationService
{
    void SendOrderConfirmation(string orderId);
}
