namespace RenderHeads.Media.AVProVideo
{
	public static class Android
	{
		public enum VideoApi
		{
			MediaPlayer = 1,
			ExoPlayer = 2
		}

		public enum AudioOutput
		{
			System = 0,
			Unity = 1,
			FacebookAudio360 = 2
		}

		public enum TextureFiltering
		{
			Point = 0,
			Bilinear = 1,
			Trilinear = 2
		}

		public const int Default_MinBufferTimeMs = 50000;

		public const int Default_MaxBufferTimeMs = 50000;

		public const int Default_BufferForPlaybackMs = 2500;

		public const int Default_BufferForPlaybackAfterRebufferMs = 5000;
	}
}
