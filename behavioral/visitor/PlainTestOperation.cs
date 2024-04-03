namespace visitor;

public class PlainTestOperation : IOperation
{
    public void Apply(HeadingNode node)
    {
        Console.WriteLine("text heading");
    }

    public void Apply(AnchorNode node)
    {
        Console.WriteLine("text anchor");
    }
}
