namespace Memento;
public class Editor
{

    private string content = null!;

    public EditorState CreateState()
    {
        return new EditorState(content);
    }

    public void Restore(EditorState state)
    {
        content = state.GetContent();
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