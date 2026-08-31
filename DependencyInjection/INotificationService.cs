namespace DependencyInjection;

public interface INotificationService
{
    void SendOrderConfirmation(string orderId);
}
