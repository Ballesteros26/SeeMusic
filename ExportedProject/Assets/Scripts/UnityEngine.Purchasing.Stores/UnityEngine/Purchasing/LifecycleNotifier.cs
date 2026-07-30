using System;

namespace UnityEngine.Purchasing
{
	internal class LifecycleNotifier : MonoBehaviour
	{
		public Action OnDestroyCallback;

		private void OnDestroy()
		{
		}
	}
}
