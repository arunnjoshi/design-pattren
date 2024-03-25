namespace Memento;

public class History
{
    private readonly Stack<EditorState> history = new();

    public void Push(EditorState state)
    {
        history.Push(state);
    }

    public EditorState Pop()
    {
        if (history.Count == 0)
            throw new InvalidOperationException("stack is empty");
        return history.Pop();
    }
}
