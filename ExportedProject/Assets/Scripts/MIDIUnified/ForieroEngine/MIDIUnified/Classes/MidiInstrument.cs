using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified.Interfaces;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Classes
{
	public abstract class MidiInstrument<T> : MonoBehaviour where T : MidiInstrument<T>, IMidiInstrument, IMidiSender, IMidiReceiver
	{
		public static MidiInstrument<T> Instance;

		public string id;

		public string Id => null;

		public event ShortMessageEventHandler ShortMessageEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void Show(bool animated = true)
		{
		}

		public virtual void Hide(bool animated = true)
		{
		}

		protected virtual void OnShortMessageEvent(int aCommand, int aData1, int aData2, int aDeviceId)
		{
		}

		public virtual void OnMidiMessageReceived(int aCommand, int aData1, int aData2, int aDeviceId)
		{
		}
	}
}
