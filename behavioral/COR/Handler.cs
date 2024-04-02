namespace COR;

public abstract class Handler
{
    private Handler next;

    public Handler(Handler next)
    {
        this.next = next;
    }

    public void Handle(HttpRequest httpRequest)
    {
        if (DoHandle(httpRequest))
        {
            return;
        }
        else if (next != null)
        {
            next.Handle(httpRequest);
        }
    }
    public abstract bool DoHandle(HttpRequest httpRequest);
}