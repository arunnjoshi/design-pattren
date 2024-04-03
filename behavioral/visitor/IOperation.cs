namespace visitor;

public interface IOperation
{
    void Apply(HeadingNode node);
    void Apply(AnchorNode node);
}
