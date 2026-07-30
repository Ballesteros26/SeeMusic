using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class InstrumentChunk : Chunk
	{
		private class RawInstrument
		{
			public string name;

			public ushort startInstrumentZoneIndex;

			public ushort endInstrumentZoneIndex;
		}

		private RawInstrument[] rawInstruments;

		public InstrumentChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}

		public Instrument[] ToInstruments(Zone[] zones)
		{
			return null;
		}
	}
}
