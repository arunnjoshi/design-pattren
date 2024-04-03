namespace visitor;

public class HtmlDocument
{
    private readonly List<IHtmlNode> nodes;

    public HtmlDocument()
    {
        nodes = [];
    }

    public void AddNode(IHtmlNode node)
    {
        nodes.Add(node);
    }

    public void Execute(IOperation operation)
    {
        foreach (var node in nodes)
        {
            node.Execute(operation);
        }
    }
}