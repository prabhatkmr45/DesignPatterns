namespace ChainOfResponsibility;

// Chain sample: each SupportHandler either handles a request or forwards it to the next handler.
// The sender does not need to know which support level will accept the request.
public sealed record SupportRequest(string Issue, int Severity);

public abstract class SupportHandler
{
    private SupportHandler? _next;
    public SupportHandler SetNext(SupportHandler next) { _next = next; return next; }
    public virtual void Handle(SupportRequest request) =>
        (_next ?? throw new InvalidOperationException("No handler accepted the request.")).Handle(request);
}

public sealed class BasicSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Severity <= 1) Console.WriteLine($"Basic support handled: {request.Issue}");
        else base.Handle(request);
    }
}

public sealed class TechnicalSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Severity <= 3) Console.WriteLine($"Technical support handled: {request.Issue}");
        else base.Handle(request);
    }
}

public sealed class ManagerSupport : SupportHandler
{
    public override void Handle(SupportRequest request) => Console.WriteLine($"Manager handled: {request.Issue}");
}

internal static class Program
{
    private static void Main()
    {
        SupportHandler chain = new BasicSupport();
        chain.SetNext(new TechnicalSupport()).SetNext(new ManagerSupport());
        chain.Handle(new("Password reset", 1));
        chain.Handle(new("Database outage", 3));
        chain.Handle(new("Contract escalation", 5));
    }
}
