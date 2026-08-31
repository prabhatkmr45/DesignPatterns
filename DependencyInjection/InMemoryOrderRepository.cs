namespace DependencyInjection;

public sealed class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<string, string> _orders = [];

    public void Save(string orderId, string product)
    {
        _orders[orderId] = product;
        Console.WriteLine($"Saved order {orderId} for {product}.");
    }
}
