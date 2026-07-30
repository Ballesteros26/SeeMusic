using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads from a string.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class StringReader : TextReader
	{
		private string _s;

		private int _pos;

		private int _length;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringReader" /> class that reads from the specified string.</summary>
		/// <param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception>
		public StringReader(string s)
		{
		}

		/// <summary>Closes the <see cref="T:System.IO.StringReader" />.</summary>
		/// <filterpriority>2</filterpriority>
		public override void Close()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringReader" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Returns the next available character but does not consume it.</summary>
		/// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the stream does not support seeking.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception>
		/// <filterpriority>2</filterpriority>
		public override int Peek()
		{
			return 0;
		}

		/// <summary>Reads the next character from the input string and advances the character position by one character.</summary>
		/// <returns>The next character from the underlying string, or -1 if no more characters are available.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception>
		/// <filterpriority>2</filterpriority>
		public override int Read()
		{
			return 0;
		}

		/// <summary>Reads a block of characters from the input string and advances the character position by <paramref name="count" />.</summary>
		/// <returns>The total number of characters read into the buffer. This can be less than the number of characters requested if that many characters are not currently available, or zero if the end of the underlying string has been reached.</returns>
		/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source. </param>
		/// <param name="index">The starting index in the buffer. </param>
		/// <param name="count">The number of characters to read. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception>
		/// <filterpriority>2</filterpriority>
		public override int Read([In][Out] char[] buffer, int index, int count)
		{
			return 0;
		}

		/// <summary>Reads all characters from the current position to the end of the string and returns them as a single string.</summary>
		/// <returns>The content from the current position to the end of the underlying string.</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception>
		/// <filterpriority>2</filterpriority>
		public override string ReadToEnd()
		{
			return null;
		}

		/// <summary>Reads a line of characters from the current string and returns the data as a string.</summary>
		/// <returns>The next line from the current string, or null if the end of the string is reached.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current reader is closed. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <filterpriority>2</filterpriority>
		public override string ReadLine()
		{
			return null;
		}

		/// <summary>Reads a line of characters asynchronously from the current string and returns the data as a string.</summary>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the next line from the string reader, or is null if all the characters have been read.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The string reader has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
		[ComVisible(false)]
		public override Task<string> ReadLineAsync()
		{
			return null;
		}

		/// <summary>Reads all characters from the current position to the end of the string asynchronously and returns them as a single string.</summary>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains a string with the characters from the current position to the end of the string. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The string reader has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
		[ComVisible(false)]
		public override Task<string> ReadToEndAsync()
		{
			return null;
		}
	}
}
