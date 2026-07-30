using System.IO;
using AudioSynthesis.Bank.Components;
using AudioSynthesis.Bank.Components.Generators;

namespace AudioSynthesis.Bank.Descriptors
{
	public class LfoDescriptor
	{
		public float DelayTime;

		public float Frequency;

		public float Depth;

		public Generator Generator;

		public int Read(BinaryReader reader)
		{
			return 0;
		}

		private static Generator GetGenerator(WaveformEnum waveform)
		{
			return null;
		}

		private void ApplyDefault()
		{
		}

		private void CheckValidParameters()
		{
		}
	}
}
