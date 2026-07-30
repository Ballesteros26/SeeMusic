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
	public static class MidiINPlugin
	{
		public static class DSP
		{
			public class Data
			{
				public bool On;

				public float PressedTime;

				public float ReleasedTime;

				public float HoldOnTime => 0f;
			}

			private static bool _initialized;

			public static readonly Data[] Tone;

			public static readonly Data[] ControlChange;

			internal static void Init()
			{
			}
		}

		private static class MidiThread
		{
			private static bool _terminating;

			private static Thread _thread;

			public static void Initialise()
			{
			}

			private static void MidiInThread()
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

		public static IMidiINDevice iMidiInDevice;

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

		public static bool through;

		public static bool synth;

		private static readonly NonBlockingQueue<MidiMessage> Messages;

		private static readonly NonBlockingQueue<MidiMessage> MessagesEditor;

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

		public static MidiDevice ConnectDeviceByName(string deviceName, bool editor = false)
		{
			return null;
		}

		public static void DisconnectDevice(MidiDevice connectedDevice)
		{
		}

		public static void DisconnectDevices(bool editor = false)
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

		public static int PopMessage(out MidiMessage midiMessage, bool editor = false)
		{
			midiMessage = default(MidiMessage);
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
