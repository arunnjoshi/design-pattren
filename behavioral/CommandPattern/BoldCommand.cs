using CommandPattern.FX;

namespace CommandPattern;

public class BoldCommand(HtmlDocument document, HistoryCommand history) : IUnDoableCommand
{
    private string preContent = null!;
    private readonly HtmlDocument document = document;
    private readonly HistoryCommand history = history;

    public void Execute()
    {
        preContent = document.GetContent();
        document.MakeBold();
        history.Push(this);
    }

    public void UnExecute()
    {
        document.SetContent(preContent);
    }
}
