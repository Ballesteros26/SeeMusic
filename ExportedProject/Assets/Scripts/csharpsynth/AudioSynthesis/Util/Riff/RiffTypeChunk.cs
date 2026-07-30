using System.IO;

namespace AudioSynthesis.Util.Riff
{
	public class RiffTypeChunk : Chunk
	{
		private string typeId;

		public string TypeId => null;

		public RiffTypeChunk(string id, int size, BinaryReader reader)
			: base(null, 0)
		{
		}
	}
}
