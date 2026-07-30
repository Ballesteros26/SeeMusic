using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class SequencerSpecificEvent : MetaEvent
	{
		private byte[] data;

		public byte[] Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SequencerSpecificEvent(BinaryReader br, int length)
		{
		}

		public SequencerSpecificEvent(byte[] data, long absoluteTime)
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
