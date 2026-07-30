using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class PresetHeaderChunk : Chunk
	{
		private class RawPreset
		{
			public string name;

			public ushort patchNumber;

			public ushort bankNumber;

			public ushort startPresetZoneIndex;

			public ushort endPresetZoneIndex;

			public uint library;

			public uint genre;

			public uint morphology;
		}

		private RawPreset[] rawPresets;

		public PresetHeaderChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}

		public PresetHeader[] ToPresets(Zone[] presetZones)
		{
			return null;
		}
	}
}
