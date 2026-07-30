using System.Runtime.CompilerServices;

namespace VideoKit.Recorders.Clocks
{
	public sealed class RealtimeClock : IClock
	{
		private long startTime;

		private bool isPaused;

		private long pauseTime;

		public long timestamp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return 0L;
			}
		}

		public bool paused
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return false;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
			}
		}

		private static long CurrentTimestamp => 0L;
	}
}
