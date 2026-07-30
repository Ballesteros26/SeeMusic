using System;

namespace UnityEngine
{
	public class AndroidJavaClass : AndroidJavaObject
	{
		public AndroidJavaClass(string className)
			: base((string)null, (string[])null)
		{
		}

		private void _AndroidJavaClass(string className)
		{
		}

		internal AndroidJavaClass(IntPtr jclass)
			: base((string)null, (string[])null)
		{
		}
	}
}
