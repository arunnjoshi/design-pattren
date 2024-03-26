namespace State;

public class Canvas
{
    private ITool currentTool = null!;

    public void MouseDown()
    {
        currentTool.MouseDown();
    }

    public void MouseUp()
    {
        currentTool.MouseUp();
    }

    public ITool GetCurrentTool()
    {
        return currentTool;
    }

    public void SetTool(ITool tool)
    {
        currentTool = tool;
    }
}
