using System;
using System.Runtime.InteropServices;

namespace ForieroEngine.MIDIUnified.Plugins
{
	internal class MidiINDeviceSTANDALONE : IMidiINDevice, IMidiDevice, IMidiEditorDevice
	{
		private const string DllName = "rtmidi";

		[PreserveSig]
		private static extern int Init(string appId);

		[PreserveSig]
		private static extern int MidiIn_PortOpen(int deviceIndex, bool editor);

		[PreserveSig]
		private static extern void MidiIn_PortClose(int deviceId, bool editor);

		[PreserveSig]
		private static extern void MidiIn_PortCloseAll(bool editor);

		[PreserveSig]
		private static extern string MidiIn_PortName(int i);

		[PreserveSig]
		private static extern int MidiIn_PortCount();

		[PreserveSig]
		private static extern int MidiIn_PortOpenVirtual(string name, bool editor);

		[PreserveSig]
		private static extern void MidiIn_PortCloseVirtual(int deviceId, bool editor);

		[PreserveSig]
		private static extern void MidiIn_PortCloseAllVirtual(bool editor);

		[PreserveSig]
		private static extern string MidiIn_PortNameVirtual(int i);

		[PreserveSig]
		private static extern int MidiIn_PortCountVirtual();

		[PreserveSig]
		private static extern int MidiIn_PopMessage(out NativeMidiMessage midiMessage, bool editor);

		[PreserveSig]
		private static extern void MidiIn_DeleteData(IntPtr midiMessage);

		[PreserveSig]
		public static extern int MidiIn_GetConnectedDeviceCount();

		[PreserveSig]
		public static extern int MidiIn_GetConnectedDeviceId(int connectedDeviceIndex);

		[PreserveSig]
		public static extern string MidiIn_GetConnectedDeviceName(int connectedDeviceIndex);

		[PreserveSig]
		public static extern bool MidiIn_GetConnectedDeviceIsEditor(int connectedDeviceIndex);

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

		public int PopMessage(out MidiMessage midiMessage, bool editor = false)
		{
			midiMessage = default(MidiMessage);
			return 0;
		}

		private static void DeleteData(IntPtr data)
		{
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
