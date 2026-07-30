namespace System.Diagnostics
{
	public static class StackFrameExtensions
	{
		public static bool HasNativeImage(this StackFrame stackFrame)
		{
			return false;
		}

		public static bool HasMethod(this StackFrame stackFrame)
		{
			return false;
		}

		public static bool HasILOffset(this StackFrame stackFrame)
		{
			return false;
		}

		public static bool HasSource(this StackFrame stackFrame)
		{
			return false;
		}

		public static IntPtr GetNativeIP(this StackFrame stackFrame)
		{
			return (IntPtr)0;
		}

		public static IntPtr GetNativeImageBase(this StackFrame stackFrame)
		{
			return (IntPtr)0;
		}
	}
}
