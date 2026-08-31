namespace Decorator;

public interface ICoffee
{
    string Description { get; }
    decimal Cost { get; }
}

public sealed class Espresso : ICoffee
{
    public string Description => "Espresso";
    public decimal Cost => 2.50m;
}

public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
{
    protected ICoffee Coffee { get; } = coffee;
    public abstract string Description { get; }
    public abstract decimal Cost { get; }
}

public sealed class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override string Description => $"{Coffee.Description}, milk";
    public override decimal Cost => Coffee.Cost + 0.50m;
}

public sealed class CaramelDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override string Description => $"{Coffee.Description}, caramel";
    public override decimal Cost => Coffee.Cost + 0.75m;
}

internal static class Program
{
    private static void Main()
    {
        ICoffee coffee = new CaramelDecorator(new MilkDecorator(new Espresso()));
        Console.WriteLine($"{coffee.Description}: ${coffee.Cost:F2}");
    }
}
