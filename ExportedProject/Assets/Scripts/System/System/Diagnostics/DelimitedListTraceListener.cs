using System.Collections;
using System.IO;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output to a text writer, such as a stream writer, or to a stream, such as a file stream.</summary>
	/// <filterpriority>1</filterpriority>
	public class DelimitedListTraceListener : TextWriterTraceListener
	{
		private string delimiter;

		private string secondaryDelim;

		private bool initializedDelim;

		/// <summary>Gets or sets the delimiter for the delimited list.</summary>
		/// <returns>The delimiter for the delimited list.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> is set to null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> is set to an empty string ("").</exception>
		/// <filterpriority>1</filterpriority>
		public string Delimiter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified output stream. </summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		public DelimitedListTraceListener(Stream stream)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified output stream and has the specified name. </summary>
		/// <param name="stream">The <see cref="T:System.IO.Stream" /> to receive the output.</param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> is null. </exception>
		public DelimitedListTraceListener(Stream stream, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified text writer. </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		public DelimitedListTraceListener(TextWriter writer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified text writer and has the specified name. </summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to receive the output.</param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="writer" /> is null. </exception>
		public DelimitedListTraceListener(TextWriter writer, string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified file.  </summary>
		/// <param name="fileName">The name of the file to receive the output.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> is null. </exception>
		public DelimitedListTraceListener(string fileName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> class that writes to the specified file and has the specified name. </summary>
		/// <param name="fileName">The name of the file to receive the output. </param>
		/// <param name="name">The name of the new instance of the trace listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> is null. </exception>
		public DelimitedListTraceListener(string fileName, string name)
		{
		}

		/// <summary>Returns the custom configuration file attribute supported by the delimited trace listener.</summary>
		/// <returns>A string array that contains the single value "delimiter".</returns>
		protected internal override string[] GetSupportedAttributes()
		{
			return null;
		}

		/// <summary>Writes trace information, a formatted array of objects, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="format">A format string that contains zero or more format items that correspond to objects in the <paramref name="args" /> array.</param>
		/// <param name="args">An array containing zero or more objects to format.</param>
		/// <filterpriority>1</filterpriority>
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
		}

		/// <summary>Writes trace information, a message, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">The trace message to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
		}

		/// <summary>Writes trace information, a data object, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">A data object to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
		}

		/// <summary>Writes trace information, an array of data objects, and event information to the output file or stream.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="data">An array of data objects to write to the output file or stream.</param>
		/// <filterpriority>1</filterpriority>
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
		}

		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
		}

		private void WriteFooter(TraceEventCache eventCache)
		{
		}

		private void WriteEscaped(string message)
		{
		}

		private void WriteStackEscaped(Stack stack)
		{
		}
	}
}
