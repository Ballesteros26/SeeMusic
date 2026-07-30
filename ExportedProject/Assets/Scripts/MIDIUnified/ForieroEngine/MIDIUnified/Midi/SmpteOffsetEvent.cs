using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	internal class SmpteOffsetEvent : MetaEvent
	{
		private byte hours;

		private byte minutes;

		private byte seconds;

		private byte frames;

		private byte subFrames;

		public int Hours => 0;

		public int Minutes => 0;

		public int Seconds => 0;

		public int Frames => 0;

		public int SubFrames => 0;

		public SmpteOffsetEvent(BinaryReader br, int length)
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
