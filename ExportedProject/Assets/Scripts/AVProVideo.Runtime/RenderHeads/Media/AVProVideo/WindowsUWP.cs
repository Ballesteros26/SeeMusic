namespace RenderHeads.Media.AVProVideo
{
	public static class WindowsUWP
	{
		public enum VideoApi
		{
			MediaFoundation = 0,
			WinRT = 1
		}

		public enum AudioOutput
		{
			System = 0,
			Unity = 1,
			FacebookAudio360 = 2,
			None = 3
		}
	}
}
