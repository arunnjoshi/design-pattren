namespace Composite;

public class Shape : IComponent
{
    public void Move()
    {
        Console.WriteLine("Move shape");
    }

    public void Render()
    {
        Console.WriteLine("Render Shape");
    }
}