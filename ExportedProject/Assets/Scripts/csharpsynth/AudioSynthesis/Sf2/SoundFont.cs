using System.IO;

namespace AudioSynthesis.Sf2
{
	public class SoundFont
	{
		private SoundFontInfo info;

		private SoundFontSampleData data;

		private SoundFontPresets presets;

		public SoundFontInfo Info => null;

		public SoundFontSampleData SampleData => null;

		public SoundFontPresets Presets => null;

		public SoundFont(Stream stream)
		{
		}

		private void Load(Stream stream)
		{
		}
	}
}
