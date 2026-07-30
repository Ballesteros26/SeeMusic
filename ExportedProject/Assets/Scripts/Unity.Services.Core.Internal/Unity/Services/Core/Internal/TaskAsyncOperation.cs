using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal class TaskAsyncOperation : AsyncOperationBase
	{
		internal static TaskScheduler Scheduler;

		private Task m_Task;

		public override bool IsCompleted => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		internal static void SetScheduler()
		{
		}
	}
}
