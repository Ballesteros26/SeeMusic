using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class TempoEvent : MetaEvent
	{
		private int microsecondsPerQuarterNote;

		public int MicrosecondsPerQuarterNote => 0;

		public double Tempo => 0.0;

		public TempoEvent(BinaryReader br, int length)
		{
		}

		public TempoEvent(int microsecondsPerQuarterNote, long absoluteTime)
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
