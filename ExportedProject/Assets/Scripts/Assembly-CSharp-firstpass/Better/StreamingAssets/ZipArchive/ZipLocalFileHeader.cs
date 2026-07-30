using System.IO;
using System.Runtime.InteropServices;

namespace Better.StreamingAssets.ZipArchive
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ZipLocalFileHeader
	{
		public const uint DataDescriptorSignature = 134695760u;

		public const uint SignatureConstant = 67324752u;

		public const int OffsetToCrcFromHeaderStart = 14;

		public const int OffsetToBitFlagFromHeaderStart = 6;

		public const int SizeOfLocalHeader = 30;

		public static bool TrySkipBlock(BinaryReader reader)
		{
			return false;
		}
	}
}
