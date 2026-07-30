using System;
using System.Runtime.CompilerServices;

namespace Sanford.Multimedia.Midi
{
	public abstract class PpqnClock : IClock
	{
		private int ppqn;

		private int tempo;

		private int periodResolution;

		private int ticksPerClock;

		private int fractionalTicks;

		private readonly int timerPeriod;

		protected bool running;

		[CompilerGenerated]
		private EventHandler Tick;

		[CompilerGenerated]
		private EventHandler Started;

		[CompilerGenerated]
		private EventHandler Stopped;

		public int Ppqn => 0;

		public abstract int Ticks { get; }

		public bool IsRunning => false;

		protected PpqnClock(int timerPeriod)
		{
		}

		protected void Reset()
		{
		}

		protected int GenerateTicks()
		{
			return 0;
		}

		private void CalculatePeriodResolution()
		{
		}

		private void CalculateTicksPerClock()
		{
		}

		protected virtual void OnTick(EventArgs e)
		{
		}

		protected virtual void OnStarted(EventArgs e)
		{
		}

		protected virtual void OnStopped(EventArgs e)
		{
		}
	}
}
