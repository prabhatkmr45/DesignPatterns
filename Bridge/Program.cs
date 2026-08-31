namespace Bridge;

// Bridge sample: Message is the abstraction hierarchy and IMessageSender is the implementation hierarchy.
// Combining them at runtime lets message types and delivery channels evolve independently.
public interface IMessageSender
{
    void Send(string subject, string body);
}

public sealed class EmailSender : IMessageSender
{
    public void Send(string subject, string body) => Console.WriteLine($"Email | {subject}: {body}");
}

public sealed class SmsSender : IMessageSender
{
    public void Send(string subject, string body) => Console.WriteLine($"SMS | {subject}: {body}");
}

public abstract class Message(IMessageSender sender)
{
    protected IMessageSender Sender { get; } = sender;
    public abstract void Send();
}

public sealed class AlertMessage(IMessageSender sender, string text) : Message(sender)
{
    public override void Send() => Sender.Send("ALERT", text.ToUpperInvariant());
}

public sealed class ReminderMessage(IMessageSender sender, string text) : Message(sender)
{
    public override void Send() => Sender.Send("Reminder", text);
}

internal static class Program
{
    private static void Main()
    {
        new AlertMessage(new SmsSender(), "Server unavailable").Send();
        new ReminderMessage(new EmailSender(), "Submit timesheet").Send();
    }
}
