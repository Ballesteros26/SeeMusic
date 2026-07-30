using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Sanford.Multimedia.Timers
{
	internal class ThreadTimerQueue
	{
		private class Tick : IComparable
		{
			public ThreadTimer Timer;

			public TimeSpan Time;

			public int CompareTo(object obj)
			{
				return 0;
			}
		}

		private Stopwatch watch;

		private Thread loop;

		private List<Tick> tickQueue;

		private static ThreadTimerQueue instance;

		public static ThreadTimerQueue Instance => null;

		private ThreadTimerQueue()
		{
		}

		public void Add(ThreadTimer timer)
		{
		}

		public void Remove(ThreadTimer timer)
		{
		}

		private static TimeSpan Min(TimeSpan x0, TimeSpan x1)
		{
			return default(TimeSpan);
		}

		private void TimerLoop()
		{
		}
	}
}
