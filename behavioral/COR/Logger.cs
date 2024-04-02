namespace COR;

public class Logger(Handler next) : Handler(next)
{
    public override bool DoHandle(HttpRequest httpRequest)
    {
        Console.WriteLine("logger");
        return false;
    }
}