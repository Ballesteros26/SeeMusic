namespace System.Diagnostics
{
	internal static class TraceInternal
	{
		private static string appName;

		private static TraceListenerCollection listeners;

		private static bool autoFlush;

		private static bool useGlobalLock;

		[ThreadStatic]
		private static int indentLevel;

		private static int indentSize;

		internal static readonly object critSec;

		public static TraceListenerCollection Listeners => null;

		internal static string AppName => null;

		public static bool AutoFlush
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool UseGlobalLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int IndentLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int IndentSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private static void SetIndentSize(int value)
		{
		}

		public static void Indent()
		{
		}

		public static void Unindent()
		{
		}

		public static void Flush()
		{
		}

		public static void Close()
		{
		}

		public static void Assert(bool condition)
		{
		}

		public static void Assert(bool condition, string message)
		{
		}

		public static void Assert(bool condition, string message, string detailMessage)
		{
		}

		public static void Fail(string message)
		{
		}

		public static void Fail(string message, string detailMessage)
		{
		}

		private static void InitializeSettings()
		{
		}

		internal static void Refresh()
		{
		}

		public static void TraceEvent(TraceEventType eventType, int id, string format, params object[] args)
		{
		}

		public static void Write(string message)
		{
		}

		public static void Write(object value)
		{
		}

		public static void Write(string message, string category)
		{
		}

		public static void Write(object value, string category)
		{
		}

		public static void WriteLine(string message)
		{
		}

		public static void WriteLine(object value)
		{
		}

		public static void WriteLine(string message, string category)
		{
		}

		public static void WriteLine(object value, string category)
		{
		}

		public static void WriteIf(bool condition, string message)
		{
		}

		public static void WriteIf(bool condition, object value)
		{
		}

		public static void WriteIf(bool condition, string message, string category)
		{
		}

		public static void WriteIf(bool condition, object value, string category)
		{
		}

		public static void WriteLineIf(bool condition, string message)
		{
		}

		public static void WriteLineIf(bool condition, object value)
		{
		}

		public static void WriteLineIf(bool condition, string message, string category)
		{
		}

		public static void WriteLineIf(bool condition, object value, string category)
		{
		}
	}
}
