using System.Runtime.CompilerServices;

namespace VideoKit.Recorders.Clocks
{
	public sealed class FixedIntervalClock : IClock
	{
		public readonly double interval;

		private readonly bool autoTick;

		private long ticks;

		public long timestamp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return 0L;
			}
		}

		public FixedIntervalClock(float framerate, bool autoTick = true)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void Tick()
		{
		}
	}
}
