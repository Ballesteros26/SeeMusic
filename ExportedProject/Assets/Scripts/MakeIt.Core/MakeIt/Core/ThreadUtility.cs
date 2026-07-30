using UnityEngine;

namespace MakeIt.Core
{
	public static class ThreadUtility
	{
		private static bool _mainThreadIdentified;

		private static int _mainThreadId;

		public static bool isMainThread => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void OnLoad()
		{
		}
	}
}
