namespace Command;

public interface ICommand
{
    void Execute();
    void Undo();
}

public sealed class Light
{
    public void TurnOn() => Console.WriteLine("Light is on.");
    public void TurnOff() => Console.WriteLine("Light is off.");
}

public sealed class TurnOnLightCommand(Light light) : ICommand
{
    public void Execute() => light.TurnOn();
    public void Undo() => light.TurnOff();
}

public sealed class RemoteControl
{
    private readonly Stack<ICommand> _history = [];
    public void Submit(ICommand command) { command.Execute(); _history.Push(command); }
    public void UndoLast() { if (_history.TryPop(out ICommand? command)) command.Undo(); }
}

internal static class Program
{
    private static void Main()
    {
        RemoteControl remote = new();
        remote.Submit(new TurnOnLightCommand(new Light()));
        remote.UndoLast();
    }
}
