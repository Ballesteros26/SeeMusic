using System.IO;

namespace MidiPlayerTK
{
	public class SFLoad
	{
		public SFData SfData;

		private BinaryReader fd;

		public SFLoad(string filename, SFFile.SfSource psource)
		{
		}

		public SFLoad(byte[] bytes, SFFile.SfSource psource)
		{
		}

		private SFChunk ReadChunk()
		{
			return null;
		}

		private string ReadId()
		{
			return null;
		}

		private string ReadStr()
		{
			return null;
		}

		private File_Chunk_ID ChunkId(string id)
		{
			return default(File_Chunk_ID);
		}

		private SFData LoadBody(long size)
		{
			return null;
		}

		private SFChunk ReadListchunk()
		{
			return null;
		}

		private void ProcessInfo(int size)
		{
		}

		private void ProcessSDta(int size)
		{
		}

		private int HelperPDta(File_Chunk_ID expid, uint reclen, out SFChunk chunk, int size)
		{
			chunk = null;
			return 0;
		}

		private void ProcessPDta(int size)
		{
		}

		private void LoadPHdr(int size)
		{
		}

		private void LoadPBag(int size)
		{
		}

		private void LoadPMod(int size)
		{
		}

		private void ProcessModulator(HiMod m)
		{
		}

		private void LoadPGen(int size)
		{
		}

		private void LoadIHdr(int size)
		{
		}

		private void LoadIBag(int size)
		{
		}

		private void LoadIMod(int size)
		{
		}

		private void LoadIGen(int size)
		{
		}

		private void LoadSHdr(int size)
		{
		}

		private void FixupPreset(SFData sf)
		{
		}

		private void FixupInstrument(SFData sf)
		{
		}

		private void FixupSample(SFData sf)
		{
		}
	}
}
