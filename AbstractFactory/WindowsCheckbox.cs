namespace AbstractFactory;

// Concrete product belonging to the Windows family.
public sealed class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows checkbox.");
    }
}
