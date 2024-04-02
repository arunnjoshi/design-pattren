namespace COR;

public class Authenticator(Handler next) : Handler(next)
{
    public override bool DoHandle(HttpRequest httpRequest)
    {
        Console.WriteLine("authentication");
        return !(httpRequest.GetUserName() == "admin" && httpRequest.GetPassword() == "1234");
    }
}