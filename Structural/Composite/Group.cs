namespace Composite;

public class Group : IComponent
{
    private readonly List<IComponent> Components = [];
    public void Add(IComponent shape)
    {
        Components.Add(shape);
    }

    public void Move()
    {
        foreach (var component in Components)
        {
            component.Move();
        }
    }

    public void Render()
    {
        foreach (var component in Components)
        {
            component.Render();
        }
    }
}