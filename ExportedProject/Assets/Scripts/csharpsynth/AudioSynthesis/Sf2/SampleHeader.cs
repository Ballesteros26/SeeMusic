using System.IO;

namespace AudioSynthesis.Sf2
{
	public class SampleHeader
	{
		private string sampleName;

		private uint start;

		private uint end;

		private uint startLoop;

		private uint endLoop;

		private uint sampleRate;

		private byte originalPitch;

		private sbyte pitchCorrection;

		private ushort sampleLink;

		private SFSampleLink soundFontSampleLink;

		public string Name => null;

		public int Start => 0;

		public int End => 0;

		public int StartLoop => 0;

		public int EndLoop => 0;

		public int SampleRate => 0;

		public byte RootKey => 0;

		public short Tune => 0;

		public SampleHeader(BinaryReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
