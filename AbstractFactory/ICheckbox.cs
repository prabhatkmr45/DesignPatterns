namespace AbstractFactory;

// Abstract product: clients use this contract without depending on a platform-specific checkbox.
public interface ICheckbox
{
    void Render();
}
