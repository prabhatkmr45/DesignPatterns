namespace Prototype;

// Prototype sample: Document is the prototype and Clone creates an independent deep copy.
// Program changes the clone to prove mutable state is not shared with the original.
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
