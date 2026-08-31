namespace Prototype;

public sealed class Document
{
    public required string Title { get; init; }
    public required List<string> Sections { get; init; }

    public Document Clone() => new()
    {
        Title = Title,
        Sections = [.. Sections]
    };
}

internal static class Program
{
    private static void Main()
    {
        Document original = new() { Title = "Quarterly Report", Sections = ["Summary", "Revenue"] };
        Document copy = original.Clone();
        copy.Sections.Add("Forecast");

        Console.WriteLine($"Original: {string.Join(", ", original.Sections)}");
        Console.WriteLine($"Clone:    {string.Join(", ", copy.Sections)}");
    }
}
