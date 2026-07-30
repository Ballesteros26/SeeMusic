using System.Runtime.InteropServices;

namespace System.Threading
{
	internal struct Win32ThreadPoolNativeOverlapped
	{
		private class ExecutionContextCallbackArgs
		{
			internal uint _errorCode;

			internal uint _bytesWritten;

			internal unsafe Win32ThreadPoolNativeOverlapped* _overlapped;

			internal OverlappedData _data;
		}

		internal class OverlappedData
		{
			internal GCHandle[] _pinnedData;

			internal IOCompletionCallback _callback;

			internal object _state;

			internal ExecutionContext _executionContext;

			internal ThreadPoolBoundHandle _boundHandle;

			internal PreAllocatedOverlapped _preAllocated;

			internal bool _completed;

			internal void Reset()
			{
			}
		}

		[ThreadStatic]
		private static ExecutionContextCallbackArgs t_executionContextCallbackArgs;

		private static ContextCallback s_executionContextCallback;

		private static OverlappedData[] s_dataArray;

		private static int s_dataCount;

		private static IntPtr s_freeList;

		private NativeOverlapped _overlapped;

		private IntPtr _nextFree;

		private int _dataIndex;

		internal OverlappedData Data => null;

		static Win32ThreadPoolNativeOverlapped()
		{
		}

		internal unsafe static Win32ThreadPoolNativeOverlapped* Allocate(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlapped preAllocated)
		{
			return null;
		}

		private unsafe static Win32ThreadPoolNativeOverlapped* AllocateNew()
		{
			return null;
		}

		private void SetData(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlapped preAllocated)
		{
		}

		internal unsafe static void Free(Win32ThreadPoolNativeOverlapped* overlapped)
		{
		}

		internal unsafe static NativeOverlapped* ToNativeOverlapped(Win32ThreadPoolNativeOverlapped* overlapped)
		{
			return null;
		}

		internal unsafe static Win32ThreadPoolNativeOverlapped* FromNativeOverlapped(NativeOverlapped* overlapped)
		{
			return null;
		}

		internal unsafe static void CompleteWithCallback(uint errorCode, uint bytesWritten, Win32ThreadPoolNativeOverlapped* overlapped)
		{
		}

		private static void OnExecutionContextCallback(object state)
		{
		}
	}
}
