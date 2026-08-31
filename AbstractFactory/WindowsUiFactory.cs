namespace AbstractFactory;

// Concrete factory: creates only Windows products, keeping the family consistent.
public sealed class WindowsUiFactory : IUiFactory
{
    public IButton CreateButton() => new WindowsButton();

    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}
