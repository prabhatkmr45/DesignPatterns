namespace AbstractFactory;

public sealed class MacUiFactory : IUiFactory
{
    public IButton CreateButton() => new MacButton();

    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
