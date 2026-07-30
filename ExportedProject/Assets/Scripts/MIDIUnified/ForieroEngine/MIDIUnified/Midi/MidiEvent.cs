using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class MidiEvent
	{
		private MidiCommandCode commandCode;

		private int channel;

		private int deltaTime;

		private long absoluteTime;

		public float eventTimeInSec;

		public float offTimeInSec;

		public float durationInSec;

		public float sustainOffTimeInSec;

		public float sustainDurationInSec;

		public bool IsOnscreen;

		public bool HasBeenDrawn;

		public float RandomValue;

		public virtual int Channel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DeltaTime => 0;

		public long AbsoluteTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public MidiCommandCode CommandCode => default(MidiCommandCode);

		public int Data1 => 0;

		public int Data2 => 0;

		public static MidiEvent FromRawMessage(int rawMessage)
		{
			return null;
		}

		public static MidiEvent ReadNextEvent(BinaryReader br, MidiEvent previous)
		{
			return null;
		}

		public virtual int GetAsShortMessage()
		{
			return 0;
		}

		protected MidiEvent()
		{
		}

		public MidiEvent(long absoluteTime, int channel, MidiCommandCode commandCode)
		{
		}

		public static bool IsNoteOff(MidiEvent midiEvent)
		{
			return false;
		}

		public static bool IsNoteOn(MidiEvent midiEvent)
		{
			return false;
		}

		public static bool IsEndTrack(MidiEvent midiEvent)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public static int ReadVarInt(BinaryReader br)
		{
			return 0;
		}

		public static void WriteVarInt(BinaryWriter writer, int value)
		{
		}

		public virtual void Export(ref long absoluteTime, BinaryWriter writer)
		{
		}
	}
}
