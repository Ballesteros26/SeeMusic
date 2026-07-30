namespace ForieroEngine.Threading.Unity
{
	public static class ThreadManagement
	{
		public static int MainThreadId { get; private set; }

		public static bool IsMainThread => false;

		public static int GetCurrentThreadId()
		{
			return 0;
		}

		public static void Initialize()
		{
		}
	}
}
