namespace SOLID.OpenClosed;

public interface IDiscountPolicy
{
    decimal Apply(decimal total);
}

public sealed class RegularDiscount : IDiscountPolicy
{
    public decimal Apply(decimal total) => total;
}

public sealed class PremiumDiscount : IDiscountPolicy
{
    public decimal Apply(decimal total) => total * 0.90m;
}

public sealed class PriceCalculator
{
    public decimal Calculate(decimal total, IDiscountPolicy policy) => policy.Apply(total);
}

public static class OpenClosedDemo
{
    public static void Run()
    {
        PriceCalculator calculator = new();
        Console.WriteLine($"OCP: Premium total is ${calculator.Calculate(100m, new PremiumDiscount()):F2}.");
    }
}
