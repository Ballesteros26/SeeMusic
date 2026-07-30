using System;
using System.ComponentModel;

namespace Sanford.Multimedia.Timers
{
	public interface ITimer : IComponent, IDisposable
	{
		int Period { set; }

		event EventHandler Tick;

		void Start();

		void Stop();
	}
}
