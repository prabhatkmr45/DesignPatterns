namespace Visitor;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}

public sealed record Circle(double Radius) : IShape
{
    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public sealed record Rectangle(double Width, double Height) : IShape
{
    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public interface IShapeVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}

public sealed class AreaVisitor : IShapeVisitor
{
    public double TotalArea { get; private set; }
    public void Visit(Circle circle) => TotalArea += Math.PI * circle.Radius * circle.Radius;
    public void Visit(Rectangle rectangle) => TotalArea += rectangle.Width * rectangle.Height;
}

internal static class Program
{
    private static void Main()
    {
        IShape[] shapes = [new Circle(3), new Rectangle(4, 5)];
        AreaVisitor visitor = new();
        foreach (IShape shape in shapes) shape.Accept(visitor);
        Console.WriteLine($"Total area: {visitor.TotalArea:F2}");
    }
}
