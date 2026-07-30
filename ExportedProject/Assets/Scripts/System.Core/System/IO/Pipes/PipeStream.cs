using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>Exposes a <see cref="T:System.IO.Stream" /> object around a pipe, which supports both anonymous and named pipes.</summary>
	public abstract class PipeStream : Stream
	{
		internal ThreadPoolBoundHandle _threadPoolBinding;

		private static readonly Task<int> s_zeroTask;

		private SafePipeHandle _handle;

		private bool _canRead;

		private bool _canWrite;

		private bool _isAsync;

		private bool _isCurrentUserOnly;

		private bool _isMessageComplete;

		private bool _isFromExistingHandle;

		private bool _isHandleExposed;

		private PipeTransmissionMode _readMode;

		private PipeTransmissionMode _transmissionMode;

		private PipeDirection _pipeDirection;

		private int _outBufferSize;

		private PipeState _state;

		/// <summary>Gets or sets a value indicating whether a <see cref="T:System.IO.Pipes.PipeStream" /> object is connected.</summary>
		/// <returns>true if the <see cref="T:System.IO.Pipes.PipeStream" /> object is connected; otherwise, false.</returns>
		public bool IsConnected => false;

		/// <summary>Gets a value indicating whether a <see cref="T:System.IO.Pipes.PipeStream" /> object was opened asynchronously or synchronously.</summary>
		/// <returns>true if the <see cref="T:System.IO.Pipes.PipeStream" /> object was opened asynchronously; otherwise, false.</returns>
		public bool IsAsync => false;

		/// <summary>Gets the safe handle for the local end of the pipe that the current <see cref="T:System.IO.Pipes.PipeStream" /> object encapsulates.</summary>
		/// <returns>A <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" /> object for the pipe that is encapsulated by the current <see cref="T:System.IO.Pipes.PipeStream" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The pipe handle has not been set.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		public SafePipeHandle SafePipeHandle => null;

		internal SafePipeHandle InternalHandle => null;

		/// <summary>Gets a value indicating whether the current stream supports read operations.</summary>
		/// <returns>true if the stream supports read operations; otherwise, false.</returns>
		public override bool CanRead => false;

		/// <summary>Gets a value indicating whether the current stream supports write operations.</summary>
		/// <returns>true if the stream supports write operations; otherwise, false.</returns>
		public override bool CanWrite => false;

		/// <summary>Gets a value indicating whether the current stream supports seek operations.</summary>
		/// <returns>false in all cases.</returns>
		public override bool CanSeek => false;

		/// <summary>Gets the length of a stream, in bytes.</summary>
		/// <returns>0 in all cases.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		public override long Length => 0L;

		/// <summary>Gets or sets the current position of the current stream.</summary>
		/// <returns>0 in all cases.</returns>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal PipeState State
		{
			get
			{
				return default(PipeState);
			}
			set
			{
			}
		}

		internal bool IsCurrentUserOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal static string GetPipePath(string serverName, string pipeName)
		{
			return null;
		}

		private void InitializeAsyncHandle(SafePipeHandle handle)
		{
		}

		private void DisposeCore(bool disposing)
		{
		}

		private int ReadCore(Span<byte> buffer)
		{
			return 0;
		}

		private Task<int> ReadAsyncCore(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		private void WriteCore(ReadOnlySpan<byte> buffer)
		{
		}

		private Task WriteAsyncCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		private unsafe int ReadFileNative(SafePipeHandle handle, Span<byte> buffer, NativeOverlapped* overlapped, out int errorCode)
		{
			errorCode = default(int);
			return 0;
		}

		private unsafe int WriteFileNative(SafePipeHandle handle, ReadOnlySpan<byte> buffer, NativeOverlapped* overlapped, out int errorCode)
		{
			errorCode = default(int);
			return 0;
		}

		internal static Interop.Kernel32.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability)
		{
			return default(Interop.Kernel32.SECURITY_ATTRIBUTES);
		}

		internal static Interop.Kernel32.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability, PipeSecurity pipeSecurity, ref GCHandle pinningHandle)
		{
			return default(Interop.Kernel32.SECURITY_ATTRIBUTES);
		}

		internal Exception WinIOError(int errorCode)
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.PipeStream" /> class using the specified <see cref="T:System.IO.Pipes.PipeDirection" /> value and buffer size.</summary>
		/// <param name="direction">One of the <see cref="T:System.IO.Pipes.PipeDirection" /> values that indicates the direction of the pipe object.</param>
		/// <param name="bufferSize">A positive <see cref="T:System.Int32" /> value greater than or equal to 0 that indicates the buffer size.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="direction" /> is not a valid <see cref="T:System.IO.Pipes.PipeDirection" /> value.-or-<paramref name="bufferSize" /> is less than 0.</exception>
		protected PipeStream(PipeDirection direction, int bufferSize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.PipeStream" /> class using the specified <see cref="T:System.IO.Pipes.PipeDirection" />, <see cref="T:System.IO.Pipes.PipeTransmissionMode" />, and buffer size.</summary>
		/// <param name="direction">One of the <see cref="T:System.IO.Pipes.PipeDirection" /> values that indicates the direction of the pipe object.</param>
		/// <param name="transmissionMode">One of the <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> values that indicates the transmission mode of the pipe object.</param>
		/// <param name="outBufferSize">A positive <see cref="T:System.Int32" /> value greater than or equal to 0 that indicates the buffer size.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="direction" /> is not a valid <see cref="T:System.IO.Pipes.PipeDirection" /> value.-or-<paramref name="transmissionMode" /> is not a valid <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> value.-or-<paramref name="bufferSize" /> is less than 0.</exception>
		protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
		{
		}

		private void Init(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
		{
		}

		/// <summary>Initializes a <see cref="T:System.IO.Pipes.PipeStream" /> object from the specified <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" /> object.</summary>
		/// <param name="handle">The <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" /> object of the pipe to initialize.</param>
		/// <param name="isExposed">true to expose the handle; otherwise, false.</param>
		/// <param name="isAsync">true to indicate that the handle was opened asynchronously; otherwise, false.</param>
		/// <exception cref="T:System.IO.IOException">A handle cannot be bound to the pipe.</exception>
		protected void InitializeHandle(SafePipeHandle handle, bool isExposed, bool isAsync)
		{
		}

		/// <summary>Reads a block of bytes from a stream and writes the data to a specified buffer.</summary>
		/// <returns>The total number of bytes that are read into <paramref name="buffer" />. This might be less than the number of bytes requested if that number of bytes is not currently available, or 0 if the end of the stream is reached.</returns>
		/// <param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source.</param>
		/// <param name="offset">The byte offset in the <paramref name="buffer" /> array at which the bytes that are read will be placed.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> is greater than the number of bytes available in <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support read operations.</exception>
		/// <exception cref="T:System.InvalidOperationException">The pipe is disconnected, waiting to connect, or the handle has not been set.</exception>
		/// <exception cref="T:System.IO.IOException">Any I/O error occurred.</exception>
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask<int>);
		}

		/// <summary>Begins an asynchronous read operation.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object that references the asynchronous read.</returns>
		/// <param name="buffer">The buffer to read data into.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin reading.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="callback">The method to call when the asynchronous read operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> is greater than the number of bytes available in <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support read operations.</exception>
		/// <exception cref="T:System.InvalidOperationException">The pipe is disconnected, waiting to connect, or the handle has not been set.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe is broken or another I/O error occurred.</exception>
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		/// <summary>Ends a pending asynchronous read request.</summary>
		/// <returns>The number of bytes that were read. A return value of 0 indicates the end of the stream (the pipe has been closed).</returns>
		/// <param name="asyncResult">The reference to the pending asynchronous request.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Pipes.PipeStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream. </exception>
		/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		/// <summary>Writes a block of bytes to the current stream using data from a buffer.</summary>
		/// <param name="buffer">The buffer that contains data to write to the pipe.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
		/// <param name="count">The maximum number of bytes to write to the current stream.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> is greater than the number of bytes available in <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support write operations.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe is broken or another I/O error occurred.</exception>
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask);
		}

		/// <summary>Begins an asynchronous write operation.</summary>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object that references the asynchronous write operation.</returns>
		/// <param name="buffer">The buffer that contains the data to write to the current stream.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <param name="callback">The method to call when the asynchronous write operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> is greater than the number of bytes available in <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support write operations.</exception>
		/// <exception cref="T:System.InvalidOperationException">The pipe is disconnected, waiting to connect, or the handle has not been set.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe is broken or another I/O error occurred.</exception>
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		/// <summary>Ends a pending asynchronous write request.</summary>
		/// <param name="asyncResult">The reference to the pending asynchronous request.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Pipes.PipeStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream. </exception>
		/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		private void CheckReadWriteArgs(byte[] buffer, int offset, int count)
		{
		}

		/// <summary>Reads a byte from a pipe.</summary>
		/// <returns>The byte, cast to <see cref="T:System.Int32" />, or -1 indicates the end of the stream (the pipe has been closed).</returns>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support read operations.</exception>
		/// <exception cref="T:System.InvalidOperationException">The pipe is disconnected, waiting to connect, or the handle has not been set.</exception>
		/// <exception cref="T:System.IO.IOException">Any I/O error occurred.</exception>
		public override int ReadByte()
		{
			return 0;
		}

		/// <summary>Writes a byte to the current stream.</summary>
		/// <param name="value">The byte to write to the stream.</param>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support write operations.</exception>
		/// <exception cref="T:System.InvalidOperationException">The pipe is disconnected, waiting to connect, or the handle has not been set.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe is broken or another I/O error occurred.</exception>
		public override void WriteByte(byte value)
		{
		}

		/// <summary>Clears the buffer for the current stream and causes any buffered data to be written to the underlying device.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The pipe does not support write operations.</exception>
		/// <exception cref="T:System.IO.IOException">The pipe is broken or another I/O error occurred.</exception>
		public override void Flush()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Pipes.PipeStream" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
		}

		internal void UpdateMessageCompletion(bool completion)
		{
		}

		/// <summary>Sets the length of the current stream to the specified value.</summary>
		/// <param name="value">The new length of the stream.</param>
		public override void SetLength(long value)
		{
		}

		/// <summary>Sets the current position of the current stream to the specified value.</summary>
		/// <returns>The new position in the stream.</returns>
		/// <param name="offset">The point, relative to <paramref name="origin" />, to begin seeking from.</param>
		/// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for <paramref name="offset" />, using a value of type <see cref="T:System.IO.SeekOrigin" />.</param>
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		/// <summary>Verifies that the pipe is in a connected state for read operations.</summary>
		protected internal void CheckReadOperations()
		{
		}

		/// <summary>Verifies that the pipe is in a connected state for write operations.</summary>
		protected internal void CheckWriteOperations()
		{
		}

		/// <summary>Gets a <see cref="T:System.IO.Pipes.PipeSecurity" /> object that encapsulates the access control list (ACL) entries for the pipe described by the current <see cref="T:System.IO.Pipes.PipeStream" /> object.</summary>
		/// <returns>A <see cref="T:System.IO.Pipes.PipeSecurity" /> object that encapsulates the access control list (ACL) entries for the pipe described by the current <see cref="T:System.IO.Pipes.PipeStream" /> object.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The underlying call to set security information failed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The underlying call to set security information failed.</exception>
		/// <exception cref="T:System.NotSupportedException">The underlying call to set security information failed.</exception>
		public PipeSecurity GetAccessControl()
		{
			return null;
		}
	}
}
