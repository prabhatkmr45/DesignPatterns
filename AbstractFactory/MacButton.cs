namespace AbstractFactory;

// Concrete product belonging to the macOS family.
public sealed class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS button.");
    }
}
