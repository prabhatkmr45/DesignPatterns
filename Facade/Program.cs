namespace Facade;

// Facade sample: the three services form a complex subsystem.
// OrderFacade coordinates them behind one simple PlaceOrder operation for the client.
public sealed class InventoryService
{
    public bool IsAvailable(string product) { Console.WriteLine($"Inventory reserved: {product}"); return true; }
}

public sealed class PaymentService
{
    public void Charge(decimal amount) => Console.WriteLine($"Payment charged: ${amount:F2}");
}

public sealed class ShippingService
{
    public void Ship(string product) => Console.WriteLine($"Shipment created: {product}");
}

public sealed class OrderFacade(InventoryService inventory, PaymentService payment, ShippingService shipping)
{
    public void PlaceOrder(string product, decimal amount)
    {
        if (!inventory.IsAvailable(product)) throw new InvalidOperationException("Product unavailable.");
        payment.Charge(amount);
        shipping.Ship(product);
        Console.WriteLine("Order completed.");
    }
}

internal static class Program
{
    private static void Main() =>
        new OrderFacade(new InventoryService(), new PaymentService(), new ShippingService())
            .PlaceOrder("Mechanical keyboard", 129.00m);
}
