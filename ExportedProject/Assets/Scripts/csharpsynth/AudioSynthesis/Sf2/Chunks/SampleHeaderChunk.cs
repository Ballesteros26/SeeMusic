using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class SampleHeaderChunk : Chunk
	{
		private SampleHeader[] sampleHeaders;

		public SampleHeader[] SampleHeaders => null;

		public SampleHeaderChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}
	}
}
