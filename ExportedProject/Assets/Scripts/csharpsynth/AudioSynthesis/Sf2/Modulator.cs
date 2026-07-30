using System.IO;

namespace AudioSynthesis.Sf2
{
	public class Modulator
	{
		private ModulatorType sourceModulationData;

		private GeneratorEnum destinationGenerator;

		private short amount;

		private ModulatorType sourceModulationAmount;

		private TransformEnum sourceTransform;

		public Modulator(BinaryReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
