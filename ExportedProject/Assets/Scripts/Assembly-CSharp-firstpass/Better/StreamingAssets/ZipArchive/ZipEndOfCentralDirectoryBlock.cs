using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct ZipEndOfCentralDirectoryBlock
	{
		public const uint SignatureConstant = 101010256u;

		public const int SizeOfBlockWithoutSignature = 18;

		public uint Signature;

		public ushort NumberOfThisDisk;

		public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

		public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

		public ushort NumberOfEntriesInTheCentralDirectory;

		public uint SizeOfCentralDirectory;

		public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

		public byte[] ArchiveComment;

		public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
		{
			eocdBlock = default(ZipEndOfCentralDirectoryBlock);
			return false;
		}
	}
}
