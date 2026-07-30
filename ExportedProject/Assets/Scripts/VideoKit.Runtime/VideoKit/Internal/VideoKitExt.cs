using System;
using System.Text;

namespace VideoKit.Internal
{
	public static class VideoKitExt
	{
		public delegate void ReadbackHandler(IntPtr context, IntPtr pixelBuffer);

		public static void CreateTexutreInput(int width, int height, ReadbackHandler handler, out IntPtr input)
		{
			input = default(IntPtr);
		}

		public static void CommitFrame(this IntPtr input, IntPtr texture, IntPtr context)
		{
		}

		public static void ReleaseTextureInput(this IntPtr input)
		{
		}

		public static void ConfigureAudioSession()
		{
		}

		public static VideoKit.Status WriteImage(byte[] data, int size, StringBuilder path, int pathLen)
		{
			return default(VideoKit.Status);
		}
	}
}
