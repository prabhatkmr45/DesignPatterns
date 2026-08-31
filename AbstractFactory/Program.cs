namespace AbstractFactory;

class Program
{
    static void Main()
    {
        RenderApplication(new WindowsUiFactory());
        Console.WriteLine();
        RenderApplication(new MacUiFactory());
    }

    private static void RenderApplication(IUiFactory factory)
    {
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();

        button.Render();
        checkbox.Render();
    }
}
