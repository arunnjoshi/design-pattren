namespace Mediator;

public class TextBox(DialogBox owner) : UIControl(owner)
{
    private string content = null!;

    public string GetContent()
    {
        return content;
    }

    public void SetContent(string content)
    {
        this.content = content;
        owner.Changed(this);
    }

}
