namespace RenderHeads.Media.AVProVideo
{
	public static class Windows
	{
		public enum VideoApi
		{
			MediaFoundation = 0,
			DirectShow = 1,
			WinRT = 2
		}

		public enum AudioOutput
		{
			System = 0,
			Unity = 1,
			FacebookAudio360 = 2,
			None = 3
		}

		public const string AudioDeviceOutputName_Vive = "HTC VIVE USB Audio";

		public const string AudioDeviceOutputName_Rift = "Headphones (Rift Audio)";
	}
}
