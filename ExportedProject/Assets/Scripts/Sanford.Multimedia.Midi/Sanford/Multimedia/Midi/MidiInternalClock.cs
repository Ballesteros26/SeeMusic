using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sanford.Multimedia.Timers;

namespace Sanford.Multimedia.Midi
{
	public class MidiInternalClock : PpqnClock, IComponent, IDisposable
	{
		private ITimer timer;

		private TempoChangeBuilder builder;

		private int ticks;

		private bool disposed;

		private ISite site;

		[CompilerGenerated]
		private EventHandler Disposed;

		public override int Ticks => 0;

		public ISite Site => null;

		public MidiInternalClock()
			: base(0)
		{
		}

		public MidiInternalClock(int timerPeriod)
			: base(0)
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		protected virtual void OnDisposed(EventArgs e)
		{
		}

		private void HandleTick(object sender, EventArgs e)
		{
		}

		public void Dispose()
		{
		}
	}
}
