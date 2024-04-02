namespace COR;

public class HttpRequest
{
    private readonly string userName;
    private readonly string password;
    public HttpRequest(string userName, string password)
    {
        this.password = password;
        this.userName = userName;
    }

    public string GetUserName()
    {
        return userName;
    }

    public string GetPassword()
    {
        return password;
    }

}
