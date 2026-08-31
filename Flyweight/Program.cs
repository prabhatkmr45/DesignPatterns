namespace Flyweight;

// Flyweight sample: TreeType holds shared intrinsic state, while Tree stores unique coordinates.
// TreeTypeFactory caches flyweights so identical tree types reuse the same object.
public sealed class TreeType(string name, string color)
{
    public void Draw(int x, int y) => Console.WriteLine($"Drawing {color} {name} at ({x}, {y}).");
}

public sealed class TreeTypeFactory
{
    private readonly Dictionary<(string, string), TreeType> _types = [];

    public TreeType Get(string name, string color)
    {
        var key = (name, color);
        if (!_types.TryGetValue(key, out TreeType? type))
        {
            type = new TreeType(name, color);
            _types[key] = type;
        }
        return type;
    }

    public int Count => _types.Count;
}

public sealed record Tree(int X, int Y, TreeType Type)
{
    public void Draw() => Type.Draw(X, Y);
}

internal static class Program
{
    private static void Main()
    {
        TreeTypeFactory factory = new();
        Tree[] forest =
        [
            new(10, 20, factory.Get("Oak", "Green")),
            new(40, 25, factory.Get("Oak", "Green")),
            new(15, 50, factory.Get("Pine", "Dark green"))
        ];
        foreach (Tree tree in forest) tree.Draw();
        Console.WriteLine($"Three trees share {factory.Count} tree-type objects.");
    }
}
