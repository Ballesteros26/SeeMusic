namespace Sanford.Multimedia.Timers
{
	public struct TimerCaps
	{
		public int periodMin;

		public int periodMax;

		public static TimerCaps Default => default(TimerCaps);
	}
}
