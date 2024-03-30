namespace CommandPattern.FX;

public class HistoryCommand
{
    private readonly Stack<IUnDoableCommand> unDoableCommands = [];

    public void Push(IUnDoableCommand command)
    {
        unDoableCommands.Push(command);
    }
    
    public IUnDoableCommand Pop()
    {
        return unDoableCommands.Pop();
    }
}
