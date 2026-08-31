namespace Observer;

// Observer sample: StockTicker is the subject and Investor objects are observers.
// A price change causes the subject to notify every current subscriber.
public interface IStockObserver
{
    void Update(string symbol, decimal price);
}

public sealed class StockTicker
{
    private readonly List<IStockObserver> _observers = [];
    public void Subscribe(IStockObserver observer) => _observers.Add(observer);
    public void SetPrice(string symbol, decimal price)
    {
        Console.WriteLine($"{symbol} changed to ${price:F2}");
        foreach (IStockObserver observer in _observers) observer.Update(symbol, price);
    }
}

public sealed class Investor(string name) : IStockObserver
{
    public void Update(string symbol, decimal price) => Console.WriteLine($"{name} notified: {symbol} = ${price:F2}");
}

internal static class Program
{
    private static void Main()
    {
        StockTicker ticker = new();
        ticker.Subscribe(new Investor("Asha"));
        ticker.Subscribe(new Investor("Ravi"));
        ticker.SetPrice("ACME", 87.25m);
    }
}
