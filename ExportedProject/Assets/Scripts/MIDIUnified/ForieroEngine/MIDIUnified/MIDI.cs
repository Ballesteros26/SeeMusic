using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

namespace ForieroEngine.MIDIUnified
{
	[RequireComponent(typeof(AudioSource))]
	public class MIDI : MonoBehaviour
	{
		private delegate void debugCallback(IntPtr request, int color, int size);

		private enum Color
		{
			red = 0,
			green = 1,
			blue = 2,
			black = 3,
			white = 4,
			yellow = 5,
			orange = 6
		}

		[CompilerGenerated]
		private sealed class _003CInit_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInit_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitSoundFontRousources_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private ResourceRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitSoundFontRousources_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitSoundFontPersistentPath_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitSoundFontPersistentPath_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitSoundFont_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitSoundFont_003Ed__21(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitMidiIO_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitMidiIO_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private AudioSource audioSource;

		public static bool forceDefaultMidiIn;

		public static int defaultMidiIn;

		public static bool forceDefaultMidiOut;

		public static int defaultMidiOut;

		public static int channelMask;

		public static int synthChannelMask;

		public static bool initialized;

		private static bool soundFontCopiedToPersistentPath;

		public static TextAsset soundFontAsset;

		public static MIDI instance;

		public static bool terminateMidiThreads;

		private const string DllName = "rtmidi";

		private static bool cleanedUp;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CInit_003Ed__7))]
		private static IEnumerator Init()
		{
			return null;
		}

		public static void RefreshMidiIO()
		{
		}

		public static void RefreshSynth()
		{
		}

		[IteratorStateMachine(typeof(_003CInitSoundFontRousources_003Ed__19))]
		private static IEnumerator InitSoundFontRousources()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInitSoundFontPersistentPath_003Ed__20))]
		private static IEnumerator InitSoundFontPersistentPath()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInitSoundFont_003Ed__21))]
		private static IEnumerator InitSoundFont()
		{
			return null;
		}

		private static void InitMIDIUnfied()
		{
		}

		[IteratorStateMachine(typeof(_003CInitMidiIO_003Ed__23))]
		private static IEnumerator InitMidiIO()
		{
			return null;
		}

		private static void InitSynth()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void AutoInit()
		{
		}

		[PreserveSig]
		private static extern void RegisterDebugCallback(debugCallback cb);

		[MonoPInvokeCallback(typeof(debugCallback))]
		private static void OnDebugCallback(IntPtr request, int color, int size)
		{
		}

		private static void CleanUp()
		{
		}
	}
}
