using CommandPattern.FX;

namespace CommandPattern;

public class AddCustomerCommand(CustomerService customerService) : ICommand
{
    private readonly CustomerService customerService = customerService;

    public void Execute()
    {
        customerService.AddCustomer();
    }
}
