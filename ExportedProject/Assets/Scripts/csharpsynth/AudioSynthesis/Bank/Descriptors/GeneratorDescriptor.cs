using System.IO;
using AudioSynthesis.Bank.Components;
using AudioSynthesis.Bank.Components.Generators;

namespace AudioSynthesis.Bank.Descriptors
{
	public class GeneratorDescriptor
	{
		public LoopModeEnum LoopMethod;

		public WaveformEnum SamplerType;

		public string AssetName;

		public double EndPhase;

		public double StartPhase;

		public double LoopEndPhase;

		public double LoopStartPhase;

		public double Offset;

		public double Period;

		public short Rootkey;

		public short KeyTrack;

		public short VelTrack;

		public short Tune;

		public int Read(BinaryReader reader)
		{
			return 0;
		}

		public Generator ToGenerator(AssetManager assets)
		{
			return null;
		}

		private void ApplyDefault()
		{
		}
	}
}
