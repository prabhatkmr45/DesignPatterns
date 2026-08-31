namespace AbstractFactory;

public sealed class WindowsUiFactory : IUiFactory
{
    public IButton CreateButton() => new WindowsButton();

    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}
