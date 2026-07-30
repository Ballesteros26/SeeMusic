using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	public static class ZipArchiveUtils
	{
		public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
		{
			expectedNumberOfEntries = default(long);
			centralDirectoryStart = default(long);
		}
	}
}
