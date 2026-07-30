using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Represents a stack trace, which is an ordered collection of one or more stack frames.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[MonoTODO("Serialized objects are not compatible with .NET")]
	[ComVisible(true)]
	public class StackTrace
	{
		internal enum TraceFormat
		{
			Normal = 0,
			TrailingNewLine = 1,
			NoResourceLookup = 2
		}

		/// <summary>Defines the default for the number of methods to omit from the stack trace. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const int METHODS_TO_SKIP = 0;

		private const string prefix = "  at ";

		private StackFrame[] frames;

		private readonly StackTrace[] captured_traces;

		private bool debug_info;

		private static bool isAotidSet;

		private static string aotid;

		/// <summary>Gets the number of frames in the stack trace.</summary>
		/// <returns>The number of frames in the stack trace. </returns>
		/// <filterpriority>2</filterpriority>
		public virtual int FrameCount => 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame.</summary>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, optionally capturing source information.</summary>
		/// <param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(bool fNeedFileInfo)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, skipping the specified number of frames and optionally capturing source information.</summary>
		/// <param name="skipFrames">The number of frames up the stack from which to start the trace. </param>
		/// <param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init_frames(int skipFrames, bool fNeedFileInfo)
		{
		}

		private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class, using the provided exception object and optionally capturing source information.</summary>
		/// <param name="e">The exception object from which to construct the stack trace. </param>
		/// <param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception>
		public StackTrace(Exception e, bool fNeedFileInfo)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class using the provided exception object, skipping the specified number of frames and optionally capturing source information.</summary>
		/// <param name="e">The exception object from which to construct the stack trace. </param>
		/// <param name="skipFrames">The number of frames up the stack from which to start the trace. </param>
		/// <param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
		public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
		}

		/// <summary>Gets the specified stack frame.</summary>
		/// <returns>The specified stack frame.</returns>
		/// <param name="index">The index of the stack frame requested. </param>
		/// <filterpriority>2</filterpriority>
		public virtual StackFrame GetFrame(int index)
		{
			return null;
		}

		/// <summary>Returns a copy of all stack frames in the current stack trace.</summary>
		/// <returns>An array of type <see cref="T:System.Diagnostics.StackFrame" /> representing the function calls in the stack trace.</returns>
		/// <filterpriority>2</filterpriority>
		[ComVisible(false)]
		public virtual StackFrame[] GetFrames()
		{
			return null;
		}

		private static string GetAotId()
		{
			return null;
		}

		private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync)
		{
			isAsync = default(bool);
			return false;
		}

		private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
		{
			skipped = default(bool);
			isAsync = default(bool);
		}

		private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType)
		{
		}

		/// <summary>Builds a readable representation of the stack trace.</summary>
		/// <returns>A readable representation of the stack trace.</returns>
		/// <filterpriority>2</filterpriority>
		public override string ToString()
		{
			return null;
		}

		internal string ToString(TraceFormat traceFormat)
		{
			return null;
		}
	}
}
