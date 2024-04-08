namespace Bridge;

public class SonyTv : IDevice
{
	public void TurnOn()
	{
        Console.WriteLine("Sony: turn on");
    }

	public void TurnOff()
	{
        Console.WriteLine("Sony: turn off");
    }

	public void SetChannel(int channel)
	{
        Console.WriteLine($"Sony: Set channel {channel} ");
    }
}
