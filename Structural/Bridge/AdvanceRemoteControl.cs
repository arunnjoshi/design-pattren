namespace Bridge;

public class AdvanceRemoteControl(IDevice device) : RemoteControl(device)
{
	private readonly IDevice device = device;

	public void SetChannel(int channel)
	{
		device.SetChannel(channel);	
	}
}