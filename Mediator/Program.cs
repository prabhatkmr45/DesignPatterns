namespace Mediator;

public interface IChatMediator
{
    void Register(User user);
    void Send(string message, User sender);
}

public sealed class ChatRoom : IChatMediator
{
    private readonly List<User> _users = [];
    public void Register(User user) => _users.Add(user);
    public void Send(string message, User sender)
    {
        foreach (User user in _users.Where(user => user != sender)) user.Receive(sender.Name, message);
    }
}

public sealed class User(string name, IChatMediator mediator)
{
    public string Name { get; } = name;
    public void Send(string message) { Console.WriteLine($"{Name} sends: {message}"); mediator.Send(message, this); }
    public void Receive(string sender, string message) => Console.WriteLine($"{Name} received from {sender}: {message}");
}

internal static class Program
{
    private static void Main()
    {
        ChatRoom room = new();
        User alice = new("Alice", room);
        User bob = new("Bob", room);
        User charlie = new("Charlie", room);
        room.Register(alice); room.Register(bob); room.Register(charlie);
        alice.Send("Hello, team!");
    }
}
