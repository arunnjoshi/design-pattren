namespace CommandPattern;

public class HtmlDocument
{
    private string content = null!;


    public void MakeBold()
    {
        content = $"<b>{content}</b>";
    }

    public string GetContent()
    {
        return content;
    }

    public void SetContent(string content)
    {
        this.content = content;
    }
}
