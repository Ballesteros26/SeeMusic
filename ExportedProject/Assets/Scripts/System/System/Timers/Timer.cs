using System.ComponentModel;
using System.Threading;

namespace System.Timers
{
	/// <summary>Generates recurring events in an application.</summary>
	[DefaultProperty("Interval")]
	[DefaultEvent("Elapsed")]
	public class Timer : Component, ISupportInitialize
	{
		private double interval;

		private bool enabled;

		private bool initializing;

		private bool delayedEnable;

		private ElapsedEventHandler onIntervalElapsed;

		private bool autoReset;

		private ISynchronizeInvoke synchronizingObject;

		private bool disposed;

		private System.Threading.Timer timer;

		private TimerCallback callback;

		private object cookie;

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
		/// <returns>true if the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event; otherwise, false. The default is false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">This property cannot be set because the timer has been disposed.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Timers.Timer.Interval" /> property was set to a value greater than <see cref="F:System.Int32.MaxValue" /> before the timer was enabled. </exception>
		[DefaultValue(false)]
		[TimersDescription("Indicates whether the timer is enabled to fire events at a defined interval.")]
		[Category("Behavior")]
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the interval at which to raise the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
		/// <returns>The time, in milliseconds, between <see cref="E:System.Timers.Timer.Elapsed" /> events. The value must be greater than zero, and less than or equal to <see cref="F:System.Int32.MaxValue" />. The default is 100 milliseconds.</returns>
		/// <exception cref="T:System.ArgumentException">The interval is less than or equal to zero.-or-The interval is greater than <see cref="F:System.Int32.MaxValue" />, and the timer is currently enabled. (If the timer is not currently enabled, no exception is thrown until it becomes enabled.) </exception>
		[SettingsBindable(true)]
		[Category("Behavior")]
		[DefaultValue(100.0)]
		[TimersDescription("The number of milliseconds between timer events.")]
		public double Interval
		{
			set
			{
			}
		}

		/// <summary>Gets or sets the site that binds the <see cref="T:System.Timers.Timer" /> to its container in design mode.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ISite" /> interface representing the site that binds the <see cref="T:System.Timers.Timer" /> object to its container.</returns>
		public override ISite Site => null;

		/// <summary>Gets or sets the object used to marshal event-handler calls that are issued when an interval has elapsed.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> representing the object used to marshal the event-handler calls that are issued when an interval has elapsed. The default is null.</returns>
		[DefaultValue(null)]
		[TimersDescription("The object used to marshal the event handler calls issued when an interval has elapsed.")]
		[Browsable(false)]
		public ISynchronizeInvoke SynchronizingObject => null;

		/// <summary>Occurs when the interval elapses.</summary>
		[TimersDescription("Occurs when the Interval has elapsed.")]
		[Category("Behavior")]
		public event ElapsedEventHandler Elapsed
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Timers.Timer" /> class, and sets all the properties to their initial values.</summary>
		public Timer()
		{
		}

		private static int CalculateRoundedInterval(double interval, bool argumentCheck = false)
		{
			return 0;
		}

		private void UpdateTimer()
		{
		}

		/// <summary>Releases the resources used by the <see cref="T:System.Timers.Timer" />.</summary>
		public void Close()
		{
		}

		/// <summary>Releases all resources used by the current <see cref="T:System.Timers.Timer" />.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Starts raising the <see cref="E:System.Timers.Timer.Elapsed" /> event by setting <see cref="P:System.Timers.Timer.Enabled" /> to true.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="T:System.Timers.Timer" /> is created with an interval equal to or greater than <see cref="F:System.Int32.MaxValue" /> + 1, or set to an interval less than zero.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public void Start()
		{
		}

		/// <summary>Stops raising the <see cref="E:System.Timers.Timer.Elapsed" /> event by setting <see cref="P:System.Timers.Timer.Enabled" /> to false.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public void Stop()
		{
		}

		private void MyTimerCallback(object state)
		{
		}
	}
}
