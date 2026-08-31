namespace Interpreter;

// Interpreter sample: each expression class represents one grammar rule.
// Composite expressions recursively interpret their child expressions to evaluate the syntax tree.
public interface IExpression
{
    int Interpret();
}

public sealed record NumberExpression(int Value) : IExpression
{
    public int Interpret() => Value;
}

public sealed record AddExpression(IExpression Left, IExpression Right) : IExpression
{
    public int Interpret() => Left.Interpret() + Right.Interpret();
}

public sealed record SubtractExpression(IExpression Left, IExpression Right) : IExpression
{
    public int Interpret() => Left.Interpret() - Right.Interpret();
}

internal static class Program
{
    private static void Main()
    {
        IExpression expression = new SubtractExpression(
            new AddExpression(new NumberExpression(10), new NumberExpression(5)),
            new NumberExpression(3));
        Console.WriteLine($"(10 + 5) - 3 = {expression.Interpret()}");
    }
}
