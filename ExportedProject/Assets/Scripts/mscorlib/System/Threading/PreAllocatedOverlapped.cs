namespace System.Threading
{
	public sealed class PreAllocatedOverlapped : IDisposable, IDeferredDisposable
	{
		internal unsafe readonly Win32ThreadPoolNativeOverlapped* _overlapped;

		private DeferredDisposableLifetime<PreAllocatedOverlapped> _lifetime;

		static PreAllocatedOverlapped()
		{
		}

		internal void Release()
		{
		}

		public void Dispose()
		{
		}

		void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
		}
	}
}
