namespace AbstractFactory;

public sealed class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows checkbox.");
    }
}
