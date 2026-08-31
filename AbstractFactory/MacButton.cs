namespace AbstractFactory;

public sealed class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS button.");
    }
}
