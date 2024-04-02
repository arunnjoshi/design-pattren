namespace COR;

public class Compressor(Handler next) : Handler(next)
{
    public override bool DoHandle(HttpRequest httpRequest)
    {
        Console.WriteLine("compress");
        return false;
    }
}