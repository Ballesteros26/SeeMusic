using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	internal class SafeThreadPoolIOHandle : SafeHandle
	{
		public override bool IsInvalid => false;

		static SafeThreadPoolIOHandle()
		{
		}

		private SafeThreadPoolIOHandle()
			: base((IntPtr)0, ownsHandle: false)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
