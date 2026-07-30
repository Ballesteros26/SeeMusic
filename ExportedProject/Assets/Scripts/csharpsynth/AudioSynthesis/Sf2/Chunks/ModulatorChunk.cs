using System.IO;
using AudioSynthesis.Util.Riff;

namespace AudioSynthesis.Sf2.Chunks
{
	public class ModulatorChunk : Chunk
	{
		private Modulator[] modulators;

		public Modulator[] Modulators => null;

		public ModulatorChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}
	}
}
