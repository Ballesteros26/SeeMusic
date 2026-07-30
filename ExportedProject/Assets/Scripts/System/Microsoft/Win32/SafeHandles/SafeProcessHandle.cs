using System;

namespace Microsoft.Win32.SafeHandles
{
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		internal static SafeProcessHandle InvalidHandle;

		internal SafeProcessHandle(IntPtr handle)
			: base(ownsHandle: false)
		{
		}

		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
			: base(ownsHandle: false)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
