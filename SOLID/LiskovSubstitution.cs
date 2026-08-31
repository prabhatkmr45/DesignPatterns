namespace SOLID.LiskovSubstitution;

// LSP: every ShippingMethod subtype honors the same cost-calculation contract.
// Checkout can substitute StandardShipping or ExpressShipping without changing correctness.
public abstract class ShippingMethod
{
    public abstract decimal CalculateCost(decimal orderTotal);
}

public sealed class StandardShipping : ShippingMethod
{
    public override decimal CalculateCost(decimal orderTotal) => orderTotal >= 100m ? 0m : 5m;
}

public sealed class ExpressShipping : ShippingMethod
{
    public override decimal CalculateCost(decimal orderTotal) => 15m;
}

public static class LiskovSubstitutionDemo
{
    private static decimal Checkout(decimal subtotal, ShippingMethod shipping) =>
        subtotal + shipping.CalculateCost(subtotal);

    public static void Run()
    {
        Console.WriteLine($"LSP: Standard checkout is ${Checkout(80m, new StandardShipping()):F2}.");
        Console.WriteLine($"LSP: Express checkout is ${Checkout(80m, new ExpressShipping()):F2}.");
    }
}
