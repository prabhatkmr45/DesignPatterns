namespace AbstractFactory;

// Abstract factory: creates a complete, compatible family of UI products.
public interface IUiFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
