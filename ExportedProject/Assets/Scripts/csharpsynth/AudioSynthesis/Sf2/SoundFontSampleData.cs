using System.IO;

namespace AudioSynthesis.Sf2
{
	public class SoundFontSampleData
	{
		private byte[] samples;

		private int bitsPerSample;

		public int BitsPerSample => 0;

		public byte[] SampleData => null;

		public SoundFontSampleData(BinaryReader reader)
		{
		}
	}
}
