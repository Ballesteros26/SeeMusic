using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified.Interfaces;
using UnityEngine;

namespace ForieroEngine.MIDIUnified.Classes
{
	public abstract class MidiController<T> : MonoBehaviour where T : MidiController<T>, IMidiController, IMidiSender, IMidiReceiver
	{
		public static MidiController<T> Instance;

		public string id;

		public RectTransform containerRT;

		private readonly Vector3[] _corners;

		public string Id => null;

		public ControllerAlignment Alignment { get; private set; }

		public bool Colored { get; set; }

		public Transform Transform => null;

		public RectTransform RectTransform => null;

		public IMidiKeys Keys { get; }

		public IMidiPercussions Percussions { get; }

		public IMidiButtons Buttons { get; }

		public IMidiKnobs Knobs { get; }

		public IMidiFaders Faders { get; }

		public bool Hidden { get; protected set; }

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

		protected virtual void OnShortMessageEvent(int aCommand, int aData1, int aData2, int aDeviceId)
		{
		}

		public virtual void OnMidiMessageReceived(int aCommand, int aData1, int aData2, int aDeviceId)
		{
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

		public virtual void Align(ControllerAlignment alignment)
		{
		}

		public virtual Vector3 GetWorldPosition(ControllerPosition p)
		{
			return default(Vector3);
		}
	}
}
