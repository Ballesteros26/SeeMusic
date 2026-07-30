using System.IO;

namespace AudioSynthesis.Sf2
{
	public class SoundFontPresets
	{
		private SampleHeader[] sHeaders;

		private PresetHeader[] pHeaders;

		private Instrument[] insts;

		public SampleHeader[] SampleHeaders => null;

		public PresetHeader[] PresetHeaders => null;

		public Instrument[] Instruments => null;

		public SoundFontPresets(BinaryReader reader)
		{
		}
	}
}
