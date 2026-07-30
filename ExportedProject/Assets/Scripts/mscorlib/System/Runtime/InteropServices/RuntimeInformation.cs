namespace System.Runtime.InteropServices
{
	public static class RuntimeInformation
	{
		private static readonly Architecture _osArchitecture;

		private static readonly Architecture _processArchitecture;

		private static readonly OSPlatform _osPlatform;

		static RuntimeInformation()
		{
		}

		private static string GetRuntimeArchitecture()
		{
			return null;
		}

		private static string GetOSName()
		{
			return null;
		}

		public static bool IsOSPlatform(OSPlatform osPlatform)
		{
			return false;
		}
	}
}
