using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ForieroEngine.Collections.NonBlocking;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Plugins
{
	public static class MidiOUTPlugin
	{
		private static class MidiThread
		{
			private static Thread _thread;

			private static bool _terminating;

			public static void Initialise()
			{
			}

			private static void MidiOutThread()
			{
			}

			public static void TerminateInternal()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COpenVirtualPortAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			public string name;

			public bool editor;

			private TaskAwaiter<int> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static IMidiOUTDevice iMidiOUTDevice;

		public static IMidiEditorDevice iMidiEditorDevice;

		public static bool initialized;

		public static List<MidiDevice> connectedDevices;

		public static List<string> deviceNames;

		private static IMidiDevice iMidiDevice;

		public static List<MidiDevice> connectedEditorDevices;

		public static Action<MidiDevice> OnDeviceConnected;

		public static Action<MidiDevice> OnEditorDeviceConnected;

		public static Action<MidiDevice> OnDeviceDisconnected;

		public static Action<MidiDevice> OnEditorDeviceDisconnected;

		public static bool threaded;

		public static int sleep;

		private static readonly NonBlockingQueue<MidiMessage> Messages;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitPlayer()
		{
		}

		public static void Init()
		{
		}

		public static void StoreConnections()
		{
		}

		public static void RestoreConnections()
		{
		}

		public static void Refresh()
		{
		}

		public static bool Initialized()
		{
			return false;
		}

		public static MidiDevice ConnectDevice(int deviceIndex, bool editor = false)
		{
			return null;
		}

		public static void DisconnectDevices(bool editor = false)
		{
		}

		public static MidiDevice ConnectDeviceByName(string deviceName, bool editor = false)
		{
			return null;
		}

		public static void DisconnectDevice(MidiDevice connectedDevice)
		{
		}

		public static void DisconnectDeviceByName(string deviceName, bool editor = false)
		{
		}

		public static string GetDeviceName(int deviceIndex)
		{
			return null;
		}

		public static int GetDeviceCount()
		{
			return 0;
		}

		public static int OpenVirtualPort(string name, bool editor = false)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003COpenVirtualPortAsync_003Ed__25))]
		public static Task<int> OpenVirtualPortAsync(string name, bool editor = false)
		{
			return null;
		}

		public static void CloseVirtualPort(int deviceId, bool editor = false)
		{
		}

		public static void CloseVirtualPorts(bool editor = false)
		{
		}

		public static int GetVirtualPortCount()
		{
			return 0;
		}

		public static string GetVirtualPortName(int portIndex)
		{
			return null;
		}

		public static int SendMidiMessage(MidiMessage m, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int SendShortMessage(byte command, byte data1, byte data2, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int SendData(byte[] data, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int GetConnectedDeviceCount()
		{
			return 0;
		}

		public static void Terminate()
		{
		}
	}
}
