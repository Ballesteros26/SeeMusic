using System.IO;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output to a <see cref="T:System.IO.TextWriter" /> or to a <see cref="T:System.IO.Stream" />, such as <see cref="T:System.IO.FileStream" />.</summary>
	/// <filterpriority>1</filterpriority>
	public class TextWriterTraceListener : TraceListener
	{
		internal TextWriter writer;

		private string fileName;

		/// <summary>Gets or sets the text writer that receives the tracing or debugging output.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the writer that receives the tracing or debugging output.</returns>
		/// <filterpriority>2</filterpriority>
		public TextWriter Writer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with <see cref="T:System.IO.TextWriter" /> as the output recipient.</summary>
		public TextWriterTraceListener()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class, using the stream as the recipient of the debugging and tracing output.</summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		public TextWriterTraceListener(Stream stream)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the stream as the recipient of the debugging and tracing output.</summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		public TextWriterTraceListener(Stream stream, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class using the specified writer as recipient of the tracing or debugging output.</summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the <see cref="T:System.Diagnostics.TextWriterTraceListener" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The writer is null. </exception>
		public TextWriterTraceListener(TextWriter writer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the specified writer as recipient of the tracing or debugging output.</summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the <see cref="T:System.Diagnostics.TextWriterTraceListener" />. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The writer is null. </exception>
		public TextWriterTraceListener(TextWriter writer, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class, using the file as the recipient of the debugging and tracing output.</summary>
		/// <param name="fileName">The name of the file the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <exception cref="T:System.ArgumentNullException">The file is null. </exception>
		public TextWriterTraceListener(string fileName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the file as the recipient of the debugging and tracing output.</summary>
		/// <param name="fileName">The name of the file the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		public TextWriterTraceListener(string fileName, string name)
		{
		}

		/// <summary>Closes the <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> so that it no longer receives tracing or debugging output.</summary>
		/// <filterpriority>1</filterpriority>
		public override void Close()
		{
		}

		/// <summary>Disposes this <see cref="T:System.Diagnostics.TextWriterTraceListener" /> object.</summary>
		/// <param name="disposing">true to release managed resources; if false, <see cref="M:System.Diagnostics.TextWriterTraceListener.Dispose(System.Boolean)" /> has no effect.</param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Flushes the output buffer for the <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />.</summary>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void Flush()
		{
		}

		/// <summary>Writes a message to this instance's <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />.</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void Write(string message)
		{
		}

		/// <summary>Writes a message to this instance's <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> followed by a line terminator. The default line terminator is a carriage return followed by a line feed (\r\n).</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void WriteLine(string message)
		{
		}

		private static Encoding GetEncodingWithFallback(Encoding encoding)
		{
			return null;
		}

		internal bool EnsureWriter()
		{
			return false;
		}
	}
}
