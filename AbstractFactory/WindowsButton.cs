namespace AbstractFactory;

// Concrete product belonging to the Windows family.
public sealed class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows button.");
    }
}
