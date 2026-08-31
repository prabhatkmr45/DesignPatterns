namespace AbstractFactory;

// Abstract product: every UI family must provide a button with this common behavior.
public interface IButton
{
    void Render();
}
