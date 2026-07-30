using System.IO;

namespace AudioSynthesis.Sf2
{
	public class ModulatorType
	{
		private PolarityEnum polarity;

		private DirectionEnum direction;

		private bool midiContinuousController;

		private SourceTypeEnum sourceType;

		private ushort controllerSource;

		public ModulatorType(BinaryReader reader)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
