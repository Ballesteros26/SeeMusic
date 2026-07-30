using System.IO;
using AudioSynthesis.Sf2;
using AudioSynthesis.Wave;

namespace AudioSynthesis.Bank
{
	public class SampleDataAsset
	{
		private string assetName;

		private int audioChannels;

		private int sampleRate;

		private short rootKey;

		private short tune;

		private double start;

		private double end;

		private double loopStart;

		private double loopEnd;

		private PcmData sampleData;

		public string Name => null;

		public int SampleRate => 0;

		public short RootKey => 0;

		public short Tune => 0;

		public double Start => 0.0;

		public double End => 0.0;

		public double LoopStart => 0.0;

		public double LoopEnd => 0.0;

		public PcmData SampleData => null;

		public SampleDataAsset(int size, BinaryReader reader)
		{
		}

		public SampleDataAsset(SampleHeader sample, SoundFontSampleData sampleData)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
