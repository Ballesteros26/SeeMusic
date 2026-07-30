using System.Security.Principal;
using System.Threading;

namespace System.IO.Pipes
{
	/// <summary>Exposes a <see cref="T:System.IO.Stream" /> around a named pipe, which supports both synchronous and asynchronous read and write operations.</summary>
	public sealed class NamedPipeClientStream : PipeStream
	{
		private readonly string _normalizedPipePath;

		private readonly TokenImpersonationLevel _impersonationLevel;

		private readonly PipeOptions _pipeOptions;

		private readonly HandleInheritability _inheritability;

		private readonly PipeDirection _direction;

		private int _access;

		private bool TryConnect(int timeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private void ValidateRemotePipeUser()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> class with the specified pipe and server names, and the specified pipe direction.</summary>
		/// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="pipeName" /> or <paramref name="serverName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="pipeName" /> or <paramref name="serverName" /> is a zero-length string.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="pipeName" /> is set to "anonymous".-or-<paramref name="direction" /> is not a valid <see cref="T:System.IO.Pipes.PipeDirection" /> value.</exception>
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction)
			: base(default(PipeDirection), 0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> class with the specified pipe and server names, and the specified pipe direction, pipe options, security impersonation level, and inheritability mode.</summary>
		/// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="impersonationLevel">One of the enumeration values that determines the security impersonation level.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle will be inheritable by child processes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="pipeName" /> or <paramref name="serverName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="pipeName" /> or <paramref name="serverName" /> is a zero-length string.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="pipeName" /> is set to "anonymous".-or-<paramref name="direction" /> is not a valid <see cref="T:System.IO.Pipes.PipeDirection" /> value.-or-<paramref name="options" /> is not a valid <see cref="T:System.IO.Pipes.PipeOptions" /> value.-or-<paramref name="impersonationLevel" /> is not a valid <see cref="T:System.Security.Principal.TokenImpersonationLevel" /> value.-or-<paramref name="inheritability" /> is not a valid <see cref="T:System.IO.HandleInheritability" /> value.</exception>
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
			: base(default(PipeDirection), 0)
		{
		}

		~NamedPipeClientStream()
		{
		}

		/// <summary>Connects to a waiting server with an infinite time-out value.</summary>
		/// <exception cref="T:System.InvalidOperationException">The client is already connected.</exception>
		public void Connect()
		{
		}

		/// <summary>Connects to a waiting server within the specified time-out period.</summary>
		/// <param name="timeout">The number of milliseconds to wait for the server to respond before the connection times out.</param>
		/// <exception cref="T:System.TimeoutException">Could not connect to the server within the specified <paramref name="timeout" /> period.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> is less than 0 and not set to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The client is already connected.</exception>
		/// <exception cref="T:System.IO.IOException">The server is connected to another client and the time-out period has expired.</exception>
		public void Connect(int timeout)
		{
		}

		private void ConnectInternal(int timeout, CancellationToken cancellationToken, int startTime)
		{
		}

		private void CheckConnectOperationsClient()
		{
		}
	}
}
