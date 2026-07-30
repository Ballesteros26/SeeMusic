namespace ForieroEngine.MIDIUnified.Plugins
{
	public interface IMidiEditorDevice
	{
		int GetConnectedDeviceCount();

		int GetConnectedDeviceId(int connectedDeviceIndex);

		string GetConnectedDeviceName(int connectedDeviceIndex);

		bool GetConnectedDeviceIsEditor(int connectedDeviceIndex);
	}
}
