namespace TemplateMethod;

public class TransferMoney : Task
{
    protected override void DoExecute()
    {
        Console.WriteLine("Transfer Money");
    }
}
