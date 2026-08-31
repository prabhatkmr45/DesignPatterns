namespace Strategy;

// Strategy sample: each IShippingStrategy encapsulates a replaceable pricing algorithm.
// Checkout uses whichever strategy is injected and remains unchanged when new algorithms are added.
public interface IShippingStrategy
{
    decimal Calculate(decimal orderTotal);
}

public sealed class StandardShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderTotal) => orderTotal >= 100 ? 0 : 5;
}

public sealed class ExpressShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderTotal) => 15;
}

public sealed class Checkout(IShippingStrategy strategy)
{
    public decimal Total(decimal subtotal) => subtotal + strategy.Calculate(subtotal);
}

internal static class Program
{
    private static void Main()
    {
        decimal subtotal = 80m;
        Console.WriteLine($"Standard total: ${new Checkout(new StandardShipping()).Total(subtotal):F2}");
        Console.WriteLine($"Express total:  ${new Checkout(new ExpressShipping()).Total(subtotal):F2}");
    }
}
