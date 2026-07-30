using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal struct ZipGenericExtraField
	{
		private const int SizeOfHeader = 4;

		private ushort _tag;

		private ushort _size;

		private byte[] _data;

		public ushort Tag => 0;

		public ushort Size => 0;

		public byte[] Data => null;

		public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
		{
			field = default(ZipGenericExtraField);
			return false;
		}
	}
}
