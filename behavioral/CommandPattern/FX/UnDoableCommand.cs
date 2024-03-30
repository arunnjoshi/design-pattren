namespace CommandPattern.FX;

public interface IUnDoableCommand : ICommand
{
    void UnExecute();
}
