using System.IO;

namespace MidiPlayerTK
{
	public class SFSave
	{
		public SFData SfData;

		private BinaryWriter fd;

		public SFSave(string fileName, SFData sf, SFFile.SfSource psource)
		{
		}

		private string ChnkIdStr(int id)
		{
			return null;
		}

		private void WriteChunk(File_Chunk_ID id, uint size)
		{
		}

		private void WriteId(File_Chunk_ID id)
		{
		}

		private void WriteStr(string var)
		{
		}

		private void WriteStrSize(string var, int size)
		{
		}

		private void WriteZero(int size)
		{
		}

		private void ChunkSize(int size)
		{
		}

		private void SaveBody()
		{
		}

		private int SaveInfo(int size)
		{
			return 0;
		}

		private int SaveSDta(int size)
		{
			return 0;
		}

		private int ProcessPDta(int size)
		{
			return 0;
		}

		private void zero_namestr(string name)
		{
		}

		private int SavePHdr(int size)
		{
			return 0;
		}

		private int SavePBAG(int size)
		{
			return 0;
		}

		private int SavePMod(int size)
		{
			return 0;
		}

		private int SavePGen(int size)
		{
			return 0;
		}

		private int SaveIHdr(int size)
		{
			return 0;
		}

		private int SaveIBag(int size)
		{
			return 0;
		}

		private int SaveIMod(int size)
		{
			return 0;
		}

		private int SaveIGen(int size)
		{
			return 0;
		}

		private int SaveSHdr(int size)
		{
			return 0;
		}
	}
}
