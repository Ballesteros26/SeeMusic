using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sanford.Multimedia.Timers
{
	internal sealed class ThreadTimer : ITimer, IComponent, IDisposable
	{
		private delegate void EventRaiser(EventArgs e);

		private ThreadTimerQueue queue;

		private bool isRunning;

		private TimerMode mode;

		private TimeSpan period;

		private TimeSpan resolution;

		private static object[] emptyArgs;

		private EventRaiser tickRaiser;

		private ISynchronizeInvoke synchronizingObject;

		private ISite site;

		[CompilerGenerated]
		private EventHandler Disposed;

		[CompilerGenerated]
		private EventHandler Started;

		[CompilerGenerated]
		private EventHandler Stopped;

		private bool disposed;

		public bool IsRunning => false;

		public TimerMode Mode => default(TimerMode);

		public int Period
		{
			set
			{
			}
		}

		public TimeSpan PeriodTimeSpan => default(TimeSpan);

		public ISite Site => null;

		public ISynchronizeInvoke SynchronizingObject => null;

		public event EventHandler Tick
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ThreadTimer()
		{
		}

		private ThreadTimer(ThreadTimerQueue queue)
		{
		}

		internal void DoTick()
		{
		}

		public void Dispose()
		{
		}

		private void OnDisposed(EventArgs e)
		{
		}

		private void OnStarted(EventArgs e)
		{
		}

		private void OnStopped(EventArgs e)
		{
		}

		private void OnTick(EventArgs e)
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}
	}
}
