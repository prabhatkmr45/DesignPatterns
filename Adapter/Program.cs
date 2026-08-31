namespace Adapter;

public interface IPaymentProcessor
{
    void Pay(decimal amount);
}

public sealed class LegacyPaymentGateway
{
    public void MakePayment(double amountInDollars) =>
        Console.WriteLine($"Legacy gateway charged ${amountInDollars:F2}.");
}

public sealed class PaymentGatewayAdapter(LegacyPaymentGateway gateway) : IPaymentProcessor
{
    public void Pay(decimal amount) => gateway.MakePayment(decimal.ToDouble(amount));
}

internal static class Program
{
    private static void Main()
    {
        IPaymentProcessor processor = new PaymentGatewayAdapter(new LegacyPaymentGateway());
        processor.Pay(149.99m);
    }
}
