using System.IO;

namespace Better.StreamingAssets.ZipArchive
{
	internal static class ZipHelper
	{
		internal const uint Mask32Bit = uint.MaxValue;

		internal const ushort Mask16Bit = ushort.MaxValue;

		private const int BackwardsSeekingBufferSize = 32;

		internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
		{
		}

		internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
		{
			return false;
		}

		internal static void AdvanceToPosition(this Stream stream, long position)
		{
		}

		private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
		{
			bufferPointer = default(int);
			return false;
		}
	}
}
