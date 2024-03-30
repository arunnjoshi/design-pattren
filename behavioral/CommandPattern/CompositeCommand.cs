using CommandPattern.FX;

namespace CommandPattern;

public class CompositeCommand : ICommand
{
    private readonly List<ICommand> _commands = [];

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}
