using System.Collections.Generic;
using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct ZipCentralDirectoryFileHeader
	{
		public const uint SignatureConstant = 33639248u;

		public byte VersionMadeByCompatibility;

		public byte VersionMadeBySpecification;

		public ushort VersionNeededToExtract;

		public ushort GeneralPurposeBitFlag;

		public ushort CompressionMethod;

		public uint LastModified;

		public uint Crc32;

		public long CompressedSize;

		public long UncompressedSize;

		public ushort FilenameLength;

		public ushort ExtraFieldLength;

		public ushort FileCommentLength;

		public int DiskNumberStart;

		public ushort InternalFileAttributes;

		public uint ExternalFileAttributes;

		public long RelativeOffsetOfLocalHeader;

		public byte[] Filename;

		public byte[] FileComment;

		public List<ZipGenericExtraField> ExtraFields;

		public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
		{
			header = default(ZipCentralDirectoryFileHeader);
			return false;
		}
	}
}
