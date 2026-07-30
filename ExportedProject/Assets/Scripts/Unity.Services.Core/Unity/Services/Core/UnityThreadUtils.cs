using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core
{
	internal static class UnityThreadUtils
	{
		private static int s_UnityThreadId;

		[CompilerGenerated]
		private static TaskScheduler _003CUnityThreadScheduler_003Ek__BackingField;

		private static TaskScheduler UnityThreadScheduler
		{
			[CompilerGenerated]
			set
			{
				_003CUnityThreadScheduler_003Ek__BackingField = value;
			}
		}

		public static bool IsRunningOnUnityThread => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureUnityThreadInfo()
		{
		}
	}
}
