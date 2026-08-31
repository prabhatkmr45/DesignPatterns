namespace State;

public interface IOrderState
{
    void Advance(Order order);
    string Name { get; }
}

public sealed class NewState : IOrderState
{
    public string Name => "New";
    public void Advance(Order order) => order.ChangeState(new PaidState());
}

public sealed class PaidState : IOrderState
{
    public string Name => "Paid";
    public void Advance(Order order) => order.ChangeState(new ShippedState());
}

public sealed class ShippedState : IOrderState
{
    public string Name => "Shipped";
    public void Advance(Order order) => Console.WriteLine("Order is already complete.");
}

public sealed class Order
{
    private IOrderState _state = new NewState();
    public void ChangeState(IOrderState state) { _state = state; Console.WriteLine($"Order state: {_state.Name}"); }
    public void Advance() => _state.Advance(this);
    public void ShowState() => Console.WriteLine($"Order state: {_state.Name}");
}

internal static class Program
{
    private static void Main()
    {
        Order order = new();
        order.ShowState(); order.Advance(); order.Advance(); order.Advance();
    }
}
