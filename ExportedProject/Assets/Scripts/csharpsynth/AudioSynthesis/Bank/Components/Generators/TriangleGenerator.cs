using AudioSynthesis.Bank.Descriptors;

namespace AudioSynthesis.Bank.Components.Generators
{
	public class TriangleGenerator : Generator
	{
		public TriangleGenerator(GeneratorDescriptor description)
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
	}
}
