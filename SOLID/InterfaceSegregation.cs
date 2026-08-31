namespace SOLID.InterfaceSegregation;

// ISP: printing and scanning are separate, focused contracts.
// BasicPrinter is not forced to implement scanning it cannot support.
public interface IPrinter
{
    void Print(string document);
}

public interface IScanner
{
    void Scan(string document);
}

public sealed class BasicPrinter : IPrinter
{
    public void Print(string document) => Console.WriteLine($"ISP: Printed {document}.");
}

public sealed class MultifunctionPrinter : IPrinter, IScanner
{
    public void Print(string document) => Console.WriteLine($"ISP: Printed {document}.");
    public void Scan(string document) => Console.WriteLine($"ISP: Scanned {document}.");
}

public static class InterfaceSegregationDemo
{
    public static void Run()
    {
        IPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("report.pdf");

        IScanner scanner = new MultifunctionPrinter();
        scanner.Scan("receipt.pdf");
    }
}
