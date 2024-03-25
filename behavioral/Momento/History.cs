namespace Momento;

public class History
{
    private Stack<EditorState> history = new Stack<EditorState>();

    public void Push(EditorState state)
    {
        history.Push(state);
    }

    public EditorState Pop()
    {
        return history.Pop();
    }
}
