namespace Mediator;

public class Button(DialogBox owner) : UIControl(owner)
{
    private bool isEnabled;

    public bool IsEnabled()
    {
        return isEnabled;
    }

    public void SetStatusButton(bool isEnabled)
    {
        this.isEnabled = isEnabled;
        owner.Changed(this);
    }
}
