using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Sanford.Multimedia.Timers
{
	internal sealed class Timer : ITimer, IComponent, IDisposable
	{
		private delegate void TimeProc(int id, int msg, int user, int param1, int param2);

		private delegate void EventRaiser(EventArgs e);

		private int timerID;

		private TimerMode mode;

		private int period;

		private int resolution;

		private TimeProc timeProcPeriodic;

		private TimeProc timeProcOneShot;

		private EventRaiser tickRaiser;

		private ISynchronizeInvoke synchronizingObject;

		private bool running;

		private bool disposed;

		private ISite site;

		private static TimerCaps caps;

		[CompilerGenerated]
		private EventHandler Started;

		[CompilerGenerated]
		private EventHandler Stopped;

		[CompilerGenerated]
		private EventHandler Disposed;

		public ISynchronizeInvoke SynchronizingObject => null;

		public int Period
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Resolution => 0;

		public TimerMode Mode => default(TimerMode);

		public bool IsRunning => false;

		public static TimerCaps Capabilities => default(TimerCaps);

		public ISite Site => null;

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

		[PreserveSig]
		private static extern int timeGetDevCaps(ref TimerCaps caps, int sizeOfTimerCaps);

		[PreserveSig]
		private static extern int timeSetEvent(int delay, int resolution, TimeProc proc, IntPtr user, int mode);

		[PreserveSig]
		private static extern int timeKillEvent(int id);

		static Timer()
		{
		}

		~Timer()
		{
		}

		private void Initialize()
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void TimerPeriodicEventCallback(int id, int msg, int user, int param1, int param2)
		{
		}

		private void TimerOneShotEventCallback(int id, int msg, int user, int param1, int param2)
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

		public void Dispose()
		{
		}
	}
}
