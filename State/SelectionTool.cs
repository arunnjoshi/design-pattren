namespace State;

public class SelectionTool : ITool
{
    public void MouseDown()
    {
        Console.WriteLine("Selection Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw dashed rectangle");
    }
}
