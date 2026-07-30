using AudioSynthesis.Bank.Descriptors;
using AudioSynthesis.Wave;

namespace AudioSynthesis.Bank.Components.Generators
{
	public class SampleGenerator : Generator
	{
		private PcmData data;

		public PcmData Samples
		{
			set
			{
			}
		}

		public SampleGenerator()
			: base(null)
		{
		}

		public SampleGenerator(GeneratorDescriptor description, AssetManager assets)
			: base(null)
		{
		}

		public override float GetValue(double phase)
		{
			return 0f;
		}

		public override void GetValues(GeneratorParameters generatorParams, float[] blockBuffer, double increment)
		{
		}

		private void Interpolate(GeneratorParameters generatorParams, float[] blockBuffer, double increment, int start, int end)
		{
		}
	}
}
