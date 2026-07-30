using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class ChannelAfterTouchEvent : MidiEvent
	{
		private byte afterTouchPressure;

		public int AfterTouchPressure
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ChannelAfterTouchEvent(BinaryReader br)
		{
		}

		public ChannelAfterTouchEvent(long absoluteTime, int channel, int afterTouchPressure)
		{
		}

		public override void Export(ref long absoluteTime, BinaryWriter writer)
		{
		}
	}
}
