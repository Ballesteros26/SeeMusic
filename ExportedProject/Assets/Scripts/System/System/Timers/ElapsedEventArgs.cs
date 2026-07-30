namespace System.Timers
{
	/// <summary>Provides data for the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
	public class ElapsedEventArgs : EventArgs
	{
		private DateTime time;

		internal ElapsedEventArgs(DateTime time)
		{
		}
	}
}
