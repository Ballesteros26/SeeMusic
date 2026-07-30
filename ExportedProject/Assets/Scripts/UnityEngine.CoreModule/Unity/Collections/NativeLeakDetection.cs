using UnityEngine;

namespace Unity.Collections
{
	public static class NativeLeakDetection
	{
		private static int s_NativeLeakDetectionMode;

		public static NativeLeakDetectionMode Mode
		{
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}
	}
}
