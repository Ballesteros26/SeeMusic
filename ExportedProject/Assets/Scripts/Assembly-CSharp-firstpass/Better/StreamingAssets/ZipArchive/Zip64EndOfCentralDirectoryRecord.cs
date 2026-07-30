using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct Zip64EndOfCentralDirectoryRecord
	{
		private const uint SignatureConstant = 101075792u;

		private const ulong NormalSize = 44uL;

		public ulong SizeOfThisRecord;

		public ushort VersionMadeBy;

		public ushort VersionNeededToExtract;

		public uint NumberOfThisDisk;

		public uint NumberOfDiskWithStartOfCD;

		public ulong NumberOfEntriesOnThisDisk;

		public ulong NumberOfEntriesTotal;

		public ulong SizeOfCentralDirectory;

		public ulong OffsetOfCentralDirectory;

		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
		{
			zip64EOCDRecord = default(Zip64EndOfCentralDirectoryRecord);
			return false;
		}
	}
}
