namespace AbstractFactory;

// Concrete product belonging to the macOS family.
public sealed class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS checkbox.");
    }
}
