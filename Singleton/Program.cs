namespace Singleton;

class Program
{
    static void Main()
    {
        Logger firstReference = Logger.Instance;
        Logger secondReference = Logger.Instance;

        firstReference.Log("Application started.");
        secondReference.Log("The same logger is used throughout the application.");

        Console.WriteLine($"Same instance: {ReferenceEquals(firstReference, secondReference)}");
    }
}
