namespace AbstractFactory;

// Concrete factory: creates only macOS products, keeping the family consistent.
public sealed class MacUiFactory : IUiFactory
{
    public IButton CreateButton() => new MacButton();

    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
