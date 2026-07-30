using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	/// <summary>Provides an <see cref="T:System.IProgress`1" /> that invokes callbacks for each reported progress value.</summary>
	/// <typeparam name="T">Specifies the type of the progress report value.</typeparam>
	public class Progress<T> : IProgress<T>
	{
		private readonly SynchronizationContext _synchronizationContext;

		private readonly Action<T> _handler;

		private readonly SendOrPostCallback _invokeHandlers;

		[CompilerGenerated]
		private EventHandler<T> ProgressChanged;

		/// <summary>Initializes the <see cref="T:System.Progress`1" /> object.</summary>
		public Progress()
		{
		}

		/// <summary>Reports a progress change.</summary>
		/// <param name="value">The value of the updated progress.</param>
		protected virtual void OnReport(T value)
		{
		}

		/// <summary>Reports a progress change.</summary>
		/// <param name="value">The value of the updated progress.</param>
		void IProgress<T>.Report(T value)
		{
		}

		private void InvokeHandlers(object state)
		{
		}
	}
}
