using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Represents a reader that can read a sequential series of characters.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public abstract class TextReader : MarshalByRefObject, IDisposable
	{
		[Serializable]
		private sealed class NullTextReader : TextReader
		{
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			public override string ReadLine()
			{
				return null;
			}
		}

		[Serializable]
		internal sealed class SyncTextReader : TextReader
		{
			internal readonly TextReader _in;

			internal SyncTextReader(TextReader t)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Peek()
			{
				return 0;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read()
			{
				return 0;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadLine()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadToEnd()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadLineAsync()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadToEndAsync()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadToEndAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public TextReader _003C_003E4__this;

			private StringBuilder _003Csb_003E5__2;

			private char[] _003Cchars_003E5__3;

			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		/// <summary>Provides a TextReader with no data to read from.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly TextReader Null;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.TextReader" /> class.</summary>
		protected TextReader()
		{
		}

		/// <summary>Closes the <see cref="T:System.IO.TextReader" /> and releases any system resources associated with the TextReader.</summary>
		/// <filterpriority>1</filterpriority>
		public virtual void Close()
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.IO.TextReader" /> object.</summary>
		public void Dispose()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.TextReader" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Reads the next character without changing the state of the reader or the character source. Returns the next available character without actually reading it from the reader.</summary>
		/// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the reader does not support seeking.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual int Peek()
		{
			return 0;
		}

		/// <summary>Reads the next character from the text reader and advances the character position by one character.</summary>
		/// <returns>The next character from the text reader, or -1 if no more characters are available. The default implementation returns -1.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual int Read()
		{
			return 0;
		}

		/// <summary>Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.</summary>
		/// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether the data is available within the reader. This method returns 0 (zero) if it is called when no more characters are left to read.</returns>
		/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source. </param>
		/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing. </param>
		/// <param name="count">The maximum number of characters to read. If the end of the reader is reached before the specified number of characters is read into the buffer, the method returns. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public virtual int Read(Span<char> buffer)
		{
			return 0;
		}

		/// <summary>Reads all characters from the current position to the end of the text reader and returns them as one string.</summary>
		/// <returns>A string that contains all characters from the current position to the end of the text reader.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
		/// <filterpriority>1</filterpriority>
		public virtual string ReadToEnd()
		{
			return null;
		}

		/// <summary>Reads a line of characters from the text reader and returns the data as a string.</summary>
		/// <returns>The next line from the reader, or null if all characters have been read.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
		/// <filterpriority>1</filterpriority>
		public virtual string ReadLine()
		{
			return null;
		}

		/// <summary>Reads a line of characters asynchronously and returns the data as a string. </summary>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the next line from the text reader, or is null if all of the characters have been read. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
		public virtual Task<string> ReadLineAsync()
		{
			return null;
		}

		/// <summary>Reads all characters from the current position to the end of the text reader asynchronously and returns them as one string.</summary>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains a string with the characters from the current position to the end of the text reader. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
		[AsyncStateMachine(typeof(_003CReadToEndAsync_003Ed__14))]
		public virtual Task<string> ReadToEndAsync()
		{
			return null;
		}

		internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		/// <summary>Creates a thread-safe wrapper around the specified TextReader.</summary>
		/// <returns>A thread-safe <see cref="T:System.IO.TextReader" />.</returns>
		/// <param name="reader">The TextReader to synchronize. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="reader" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		public static TextReader Synchronized(TextReader reader)
		{
			return null;
		}
	}
}
