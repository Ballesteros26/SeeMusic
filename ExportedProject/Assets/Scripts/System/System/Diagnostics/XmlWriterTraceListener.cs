using System.IO;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output as XML-encoded data to a <see cref="T:System.IO.TextWriter" /> or to a <see cref="T:System.IO.Stream" />, such as a <see cref="T:System.IO.FileStream" />.</summary>
	/// <filterpriority>1</filterpriority>
	public class XmlWriterTraceListener : TextWriterTraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class, using the specified stream as the recipient of the debugging and tracing output. </summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the trace listener writes to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		public XmlWriterTraceListener(Stream stream)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified stream as the recipient of the debugging and tracing output. </summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the trace listener writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		public XmlWriterTraceListener(Stream stream, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class using the specified writer as the recipient of the debugging and tracing output. </summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the trace listener.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		public XmlWriterTraceListener(TextWriter writer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified writer as the recipient of the debugging and tracing output. </summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the trace listener. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		public XmlWriterTraceListener(TextWriter writer, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class, using the specified file as the recipient of the debugging and tracing output. </summary>
		/// <param name="filename">The name of the file to write to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="filename" /> is null. </exception>
		public XmlWriterTraceListener(string filename)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> class with the specified name, using the specified file as the recipient of the debugging and tracing output.  </summary>
		/// <param name="filename">The name of the file to write to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		public XmlWriterTraceListener(string filename, string name)
		{
		}
	}
}
