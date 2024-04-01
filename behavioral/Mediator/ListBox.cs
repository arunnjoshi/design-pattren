namespace Mediator;

public class ListBox(DialogBox owner) : UIControl(owner)
{
    private string selection = null!;

    public string GetSelection()
    {
        return selection;
    }

    public void SetSelection(string selection)
    {
        this.selection = selection;
        owner.Changed(this);
    }
}