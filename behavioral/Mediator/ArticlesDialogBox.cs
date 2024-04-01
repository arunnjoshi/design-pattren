namespace Mediator;

public class ArticlesDialogBox : DialogBox
{
    private readonly ListBox listBox;
    private readonly TextBox textBox;
    private readonly Button button;

    public ArticlesDialogBox()
    {
        listBox = new ListBox(this);
        textBox = new TextBox(this);
        button = new Button(this);
    }

    public void SimulateUserIntegration()
    {
        listBox.SetSelection("Arun Joshi");
        Console.WriteLine($"text box: {textBox.GetContent()}");
        Console.WriteLine($"button status: {button.IsEnabled()}");

        textBox.SetContent("");
        Console.WriteLine($"button status: {button.IsEnabled()}");
    }

    public override void Changed(UIControl control)
    {
        if (control == listBox)
        {
            textBox.SetContent(listBox.GetSelection());
            button.SetStatusButton(true);
        }
        else if(control == textBox)
        {
            string content = textBox.GetContent();
            button.SetStatusButton(!string.IsNullOrEmpty(content));
        }
    }
}
