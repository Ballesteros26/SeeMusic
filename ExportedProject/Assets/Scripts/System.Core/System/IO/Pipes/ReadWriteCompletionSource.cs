using System.Threading;

namespace System.IO.Pipes
{
	internal sealed class ReadWriteCompletionSource : PipeCompletionSource<int>
	{
		private readonly bool _isWrite;

		private readonly PipeStream _pipeStream;

		private bool _isMessageComplete;

		private int _numBytes;

		internal ReadWriteCompletionSource(PipeStream stream, ReadOnlyMemory<byte> bufferToPin, bool isWrite)
			: base((ThreadPoolBoundHandle)null, default(ReadOnlyMemory<byte>))
		{
		}

		internal override void SetCompletedSynchronously()
		{
		}

		protected override void AsyncCallback(uint errorCode, uint numBytes)
		{
		}

		protected override void HandleError(int errorCode)
		{
		}
	}
}
