namespace Singleton;

/// <summary>
/// A thread-safe singleton that is created only when it is first requested.
/// </summary>
public sealed class Logger
{
    private static readonly Lazy<Logger> LazyInstance =
        new(() => new Logger());

    private Logger()
    {
    }

    public static Logger Instance => LazyInstance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}
