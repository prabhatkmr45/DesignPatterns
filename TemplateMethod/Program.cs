namespace TemplateMethod;

// Template Method sample: Export fixes the algorithm sequence in the base class.
// Subclasses customize only the formatting step while shared read/save steps remain reusable.
public abstract class DataExporter
{
    public void Export()
    {
        string data = ReadData();
        string formatted = FormatData(data);
        Save(formatted);
    }

    protected virtual string ReadData() => "name,score\nAsha,95";
    protected abstract string FormatData(string data);
    protected virtual void Save(string data) => Console.WriteLine(data);
}

public sealed class JsonExporter : DataExporter
{
    protected override string FormatData(string data) => "{ \"name\": \"Asha\", \"score\": 95 }";
}

public sealed class HtmlExporter : DataExporter
{
    protected override string FormatData(string data) => "<p>Asha: 95</p>";
}

internal static class Program
{
    private static void Main()
    {
        new JsonExporter().Export();
        new HtmlExporter().Export();
    }
}
