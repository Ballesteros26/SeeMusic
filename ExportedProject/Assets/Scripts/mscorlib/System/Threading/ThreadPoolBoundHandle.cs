using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	public sealed class ThreadPoolBoundHandle : IDisposable, IDeferredDisposable
	{
		private readonly SafeHandle _handle;

		private readonly SafeThreadPoolIOHandle _threadPoolHandle;

		private DeferredDisposableLifetime<ThreadPoolBoundHandle> _lifetime;

		public SafeHandle Handle => null;

		static ThreadPoolBoundHandle()
		{
		}

		private ThreadPoolBoundHandle(SafeHandle handle, SafeThreadPoolIOHandle threadPoolHandle)
		{
		}

		public static ThreadPoolBoundHandle BindHandle(SafeHandle handle)
		{
			return null;
		}

		[CLSCompliant(false)]
		public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData)
		{
			return null;
		}

		[CLSCompliant(false)]
		public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped)
		{
		}

		[CLSCompliant(false)]
		public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped)
		{
			return null;
		}

		private unsafe static Win32ThreadPoolNativeOverlapped.OverlappedData GetOverlappedData(Win32ThreadPoolNativeOverlapped* overlapped, ThreadPoolBoundHandle expectedBoundHandle)
		{
			return null;
		}

		[NativeCallable(CallingConvention = CallingConvention.StdCall)]
		private static void OnNativeIOCompleted(IntPtr instance, IntPtr context, IntPtr overlappedPtr, uint ioResult, UIntPtr numberOfBytesTransferred, IntPtr ioPtr)
		{
		}

		private bool AddRef()
		{
			return false;
		}

		private void Release()
		{
		}

		public void Dispose()
		{
		}

		~ThreadPoolBoundHandle()
		{
		}

		void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
		}
	}
}
