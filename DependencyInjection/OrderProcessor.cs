namespace DependencyInjection;

public sealed class OrderProcessor(
    IOrderRepository orderRepository,
    INotificationService notificationService)
{
    public void PlaceOrder(string orderId, string product)
    {
        orderRepository.Save(orderId, product);
        notificationService.SendOrderConfirmation(orderId);
        Console.WriteLine("Order processing completed.");
    }
}
