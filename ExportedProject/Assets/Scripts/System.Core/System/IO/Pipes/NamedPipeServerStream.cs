using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>Exposes a <see cref="T:System.IO.Stream" /> around a named pipe, supporting both synchronous and asynchronous read and write operations.</summary>
	public sealed class NamedPipeServerStream : PipeStream
	{
		internal class ExecuteHelper
		{
			internal PipeStreamImpersonationWorker _userCode;

			internal SafePipeHandle _handle;

			internal bool _mustRevert;

			internal int _impersonateErrorCode;

			internal int _revertImpersonateErrorCode;
		}

		private static RuntimeHelpers.TryCode tryCode;

		private static RuntimeHelpers.CleanupCode cleanupCode;

		private void Create(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, HandleInheritability inheritability)
		{
		}

		private void Create(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
		{
		}

		/// <summary>Waits for a client to connect to this <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> object.</summary>
		/// <exception cref="T:System.InvalidOperationException">A pipe connection has already been established.-or-The pipe handle has not been set.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe connection has been broken.</exception>
		public void WaitForConnection()
		{
		}

		private static void ImpersonateAndTryCode(object helper)
		{
		}

		private static void RevertImpersonationOnBackout(object helper, bool exceptionThrown)
		{
		}

		private Task WaitForConnectionCoreAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private void CheckConnectOperationsServerWithHandle()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, pipe options, and recommended in and out buffer sizes.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="inBufferSize">A positive value greater than 0 that indicates the input buffer size.</param>
		/// <param name="outBufferSize">A positive value greater than 0 that indicates the output buffer size.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="pipeName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="pipeName" /> is set to "anonymous".-or-<paramref name="direction" /> is not a valid <see cref="T:System.IO.Pipes.PipeDirection" /> value.-or-<paramref name="maxNumberofServerInstances" /> is less than one or greater than 254.-or-<paramref name="options" /> is not a valid <see cref="T:System.IO.Pipes.PipeOptions" /> value.-or-<paramref name="inBufferSize" /> is negative.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="T:System.IO.IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize)
			: base(default(PipeDirection), 0)
		{
		}

		private NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, HandleInheritability inheritability)
			: base(default(PipeDirection), 0)
		{
		}

		~NamedPipeServerStream()
		{
		}

		private void CheckConnectOperationsServer()
		{
		}
	}
}
