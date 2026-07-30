namespace Sanford.Multimedia.Timers
{
	public static class TimerFactory
	{
		private static bool IsRunningOnMono()
		{
			return false;
		}

		public static ITimer Create()
		{
			return null;
		}
	}
}
