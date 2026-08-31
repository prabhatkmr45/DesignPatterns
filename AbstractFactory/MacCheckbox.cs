namespace AbstractFactory;

public sealed class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS checkbox.");
    }
}
