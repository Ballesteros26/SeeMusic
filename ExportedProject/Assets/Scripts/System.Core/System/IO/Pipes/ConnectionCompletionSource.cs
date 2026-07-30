using System.Threading;

namespace System.IO.Pipes
{
	internal sealed class ConnectionCompletionSource : PipeCompletionSource<VoidResult>
	{
		private readonly NamedPipeServerStream _serverStream;

		internal ConnectionCompletionSource(NamedPipeServerStream server)
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

		protected override void HandleUnexpectedCancellation()
		{
		}
	}
}
