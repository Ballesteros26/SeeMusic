using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class ZoneChunk : Chunk
	{
		private class RawZoneData
		{
			public ushort generatorIndex;

			public ushort modulatorIndex;

			public ushort generatorCount;

			public ushort modulatorCount;
		}

		private RawZoneData[] zoneData;

		public ZoneChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}

		public Zone[] ToZones(Modulator[] modulators, Generator[] generators)
		{
			return null;
		}
	}
}
