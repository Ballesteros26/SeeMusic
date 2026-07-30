using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
	internal abstract class PipeCompletionSource<TResult> : TaskCompletionSource<TResult>
	{
		private readonly ThreadPoolBoundHandle _threadPoolBinding;

		private CancellationTokenRegistration _cancellationRegistration;

		private int _errorCode;

		private unsafe NativeOverlapped* _overlapped;

		private MemoryHandle _pinnedMemory;

		private int _state;

		internal unsafe NativeOverlapped* Overlapped => null;

		protected PipeCompletionSource(ThreadPoolBoundHandle handle, ReadOnlyMemory<byte> bufferToPin)
		{
		}

		internal void RegisterForCancellation(CancellationToken cancellationToken)
		{
		}

		internal void ReleaseResources()
		{
		}

		internal abstract void SetCompletedSynchronously();

		protected virtual void AsyncCallback(uint errorCode, uint numBytes)
		{
		}

		protected abstract void HandleError(int errorCode);

		private void Cancel()
		{
		}

		protected virtual void HandleUnexpectedCancellation()
		{
		}

		private void CompleteCallback(int resultState)
		{
		}
	}
}
