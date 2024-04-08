namespace Bridge;

public class SamsungTv : IDevice
{
	public void SetChannel(int channel)
	{
		Console.WriteLine($"Samsung: set channel {channel}");
	}

	public void TurnOff()
	{
		Console.WriteLine("Samsung: turn off");
	}

	public void TurnOn()
	{
		Console.WriteLine("Samsung: turn on");
	}
}
