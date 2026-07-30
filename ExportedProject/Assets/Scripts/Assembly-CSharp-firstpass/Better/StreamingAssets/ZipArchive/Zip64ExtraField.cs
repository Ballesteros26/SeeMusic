using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct Zip64ExtraField
	{
		public const int OffsetToFirstField = 4;

		private const ushort TagConstant = 1;

		private ushort _size;

		private long? _uncompressedSize;

		private long? _compressedSize;

		private long? _localHeaderOffset;

		private int? _startDiskNumber;

		public long? UncompressedSize
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long? CompressedSize
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long? LocalHeaderOffset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int? StartDiskNumber => null;

		private void UpdateSize()
		{
		}

		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			return default(Zip64ExtraField);
		}

		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			zip64Block = default(Zip64ExtraField);
			return false;
		}
	}
}
