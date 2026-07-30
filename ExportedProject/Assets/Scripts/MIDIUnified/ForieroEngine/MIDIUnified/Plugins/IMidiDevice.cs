namespace ForieroEngine.MIDIUnified.Plugins
{
	public interface IMidiDevice
	{
		bool Init();

		int ConnectDevice(int deviceIndex, bool editor = false);

		void DisconnectDevice(int deviceId, bool editor = false);

		void DisconnectDevices(bool editor = false);

		int GetDeviceCount();

		string GetDeviceName(int deviceIndex);

		int OpenVirtualPort(string name, bool editor = false);

		void CloseVirtualPort(int deviceId, bool editor = false);

		void CloseVirtualPorts(bool editor = false);

		int GetVirtualPortCount();

		string GetVirtualPortName(int portIndex);
	}
}
