using CommandPattern.FX;

namespace CommandPattern;

public class ResizeCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Resize Command");
    }
}
