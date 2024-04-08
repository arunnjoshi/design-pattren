namespace Bridge;

public class RemoteControl
{
	private IDevice device;

	public RemoteControl(IDevice device)
	{
		this.device = device;
	}

	public void TurnOn()
	{
		device.TurnOn();
	}
	public void TurnOff()
	{
		device.TurnOff();
	}
}
