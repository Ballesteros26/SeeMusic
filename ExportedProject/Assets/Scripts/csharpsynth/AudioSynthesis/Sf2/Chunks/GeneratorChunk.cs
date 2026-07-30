using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class GeneratorChunk : Chunk
	{
		private Generator[] generators;

		public Generator[] Generators => null;

		public GeneratorChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}
	}
}
