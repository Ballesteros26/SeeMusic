using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class GenModifier
	{
		public static List<MPTKListItem> RealTimeGenerator;

		public MPTKModeGeneratorChange Mode;

		public float NormalizedVal;

		public float SoundFontVal;

		public static float DefaultNormalizedVal(fluid_gen_type genType)
		{
			return 0f;
		}

		public static void InitListGenerator()
		{
		}
	}
}
