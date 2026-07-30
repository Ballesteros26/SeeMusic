namespace VideoKit
{
	public static class VideoKitExtensions
	{
		public static bool SupportsVideo(this MediaFormat format)
		{
			return false;
		}

		public static bool SupportsAudio(this MediaFormat format)
		{
			return false;
		}
	}
}
