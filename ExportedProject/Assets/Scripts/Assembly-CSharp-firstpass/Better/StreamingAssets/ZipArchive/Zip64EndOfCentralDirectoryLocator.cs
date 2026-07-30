using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct Zip64EndOfCentralDirectoryLocator
	{
		public const uint SignatureConstant = 117853008u;

		public const int SizeOfBlockWithoutSignature = 16;

		public uint NumberOfDiskWithZip64EOCD;

		public ulong OffsetOfZip64EOCD;

		public uint TotalNumberOfDisks;

		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
		{
			zip64EOCDLocator = default(Zip64EndOfCentralDirectoryLocator);
			return false;
		}
	}
}
