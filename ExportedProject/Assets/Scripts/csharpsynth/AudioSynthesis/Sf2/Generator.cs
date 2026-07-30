using System.IO;

namespace AudioSynthesis.Sf2
{
	public class Generator
	{
		private GeneratorEnum gentype;

		private ushort rawAmount;

		public GeneratorEnum GeneratorType => default(GeneratorEnum);

		public short AmountInt16 => 0;

		public Generator(BinaryReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
