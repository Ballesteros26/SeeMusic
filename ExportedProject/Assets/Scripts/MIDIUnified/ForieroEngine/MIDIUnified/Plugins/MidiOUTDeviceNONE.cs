namespace ForieroEngine.MIDIUnified.Plugins
{
	internal class MidiOUTDeviceNONE : IMidiOUTDevice, IMidiDevice
	{
		public bool Init()
		{
			return false;
		}

		public int ConnectDevice(int deviceIndex, bool editor = false)
		{
			return 0;
		}

		public void DisconnectDevice(int deviceId, bool editor = false)
		{
		}

		public void DisconnectDevices(bool editor = false)
		{
		}

		public string GetDeviceName(int deviceIndex)
		{
			return null;
		}

		public int GetDeviceCount()
		{
			return 0;
		}

		public int OpenVirtualPort(string name, bool editor = false)
		{
			return 0;
		}

		public void CloseVirtualPort(int deviceId, bool editor = false)
		{
		}

		public void CloseVirtualPorts(bool editor = false)
		{
		}

		public int GetVirtualPortCount()
		{
			return 0;
		}

		public string GetVirtualPortName(int portIndex)
		{
			return null;
		}

		public int SendMessage(byte command, byte data1, byte data2, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public int SendData(byte[] data, int deviceId = -1, bool editor = false)
		{
			return 0;
		}
	}
}
