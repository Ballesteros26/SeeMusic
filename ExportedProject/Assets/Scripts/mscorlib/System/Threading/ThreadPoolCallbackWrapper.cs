using Internal.Runtime.Augments;

namespace System.Threading
{
	internal struct ThreadPoolCallbackWrapper
	{
		private RuntimeThread _currentThread;

		public static ThreadPoolCallbackWrapper Enter()
		{
			return default(ThreadPoolCallbackWrapper);
		}

		public void Exit(bool resetThread = true)
		{
		}
	}
}
