using System.Runtime.InteropServices;

namespace ForieroEngine.MIDIUnified.Plugins
{
	internal class MidiOUTDeviceSTANDALONE : IMidiOUTDevice, IMidiDevice, IMidiEditorDevice
	{
		private const string DllName = "rtmidi";

		[PreserveSig]
		private static extern int Init(string appId);

		[PreserveSig]
		private static extern int MidiOut_PortOpen(int deviceIndex, bool editor);

		[PreserveSig]
		private static extern void MidiOut_PortClose(int deviceId, bool editor);

		[PreserveSig]
		private static extern void MidiOut_PortCloseAll(bool editor);

		[PreserveSig]
		private static extern string MidiOut_PortName(int deviceIndex);

		[PreserveSig]
		private static extern int MidiOut_PortCount();

		[PreserveSig]
		private static extern int MidiOut_PortOpenVirtual(string name, bool editor);

		[PreserveSig]
		private static extern void MidiOut_PortCloseVirtual(int deviceId, bool editor);

		[PreserveSig]
		private static extern void MidiOut_PortCloseAllVirtual(bool editor);

		[PreserveSig]
		private static extern string MidiOut_PortNameVirtual(int deviceIndex);

		[PreserveSig]
		private static extern int MidiOut_PortCountVirtual();

		[PreserveSig]
		private static extern int MidiOut_SendMessage(int command, int data1, int data2, int deviceId, bool editor);

		[PreserveSig]
		private static extern int MidiOut_SendData(byte[] Data, int dataSize, int deviceId, bool editor);

		[PreserveSig]
		public static extern int MidiOut_GetConnectedDeviceCount();

		[PreserveSig]
		public static extern int MidiOut_GetConnectedDeviceId(int connectedDeviceIndex);

		[PreserveSig]
		public static extern string MidiOut_GetConnectedDeviceName(int connectedDeviceIndex);

		[PreserveSig]
		public static extern bool MidiOut_GetConnectedDeviceIsEditor(int connectedDeviceIndex);

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

		public int GetConnectedDeviceCount()
		{
			return 0;
		}

		public int GetConnectedDeviceId(int connectedDeviceIndex)
		{
			return 0;
		}

		public string GetConnectedDeviceName(int connectedDeviceIndex)
		{
			return null;
		}

		public bool GetConnectedDeviceIsEditor(int connectedDeviceIndex)
		{
			return false;
		}
	}
}
