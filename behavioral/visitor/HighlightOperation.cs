namespace visitor;

public class HighlightOperation : IOperation
{
    public void Apply(HeadingNode node)
    {
        Console.WriteLine("Highlight heading");
    }

    public void Apply(AnchorNode node)
    {
        Console.WriteLine("Highlight anchor");
    }
}
