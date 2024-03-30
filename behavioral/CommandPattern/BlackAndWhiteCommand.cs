using CommandPattern.FX;

namespace CommandPattern;

public class BlackAndWhiteCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("applying b&w background to image");
    }
}
