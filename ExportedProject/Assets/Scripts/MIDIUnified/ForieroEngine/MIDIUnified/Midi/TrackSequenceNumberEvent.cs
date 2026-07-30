using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class TrackSequenceNumberEvent : MetaEvent
	{
		private ushort sequenceNumber;

		public TrackSequenceNumberEvent(BinaryReader br, int length)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override void Export(ref long absoluteTime, BinaryWriter writer)
		{
		}
	}
}
