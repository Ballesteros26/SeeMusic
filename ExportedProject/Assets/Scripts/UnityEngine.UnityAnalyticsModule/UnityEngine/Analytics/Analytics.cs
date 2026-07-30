using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
	[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	public static class Analytics
	{
		[ThreadSafe]
		internal static bool IsInitialized()
		{
			return false;
		}

		[StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
		private static AnalyticsResult SendCustomEventName(string customEventName)
		{
			return default(AnalyticsResult);
		}

		[StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
		private static AnalyticsResult SendCustomEvent(CustomEventData eventData)
		{
			return default(AnalyticsResult);
		}

		public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData)
		{
			return default(AnalyticsResult);
		}
	}
}
