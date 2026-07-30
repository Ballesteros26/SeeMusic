using System.Collections.Generic;
using System.Threading.Tasks;
using Parse.Analytics.Internal;
using Parse.Core.Internal;

namespace Parse
{
	public class ParseAnalytics
	{
		internal static IParseAnalyticsController AnalyticsController => null;

		internal static IParseCurrentUserController CurrentUserController => null;

		public static Task TrackAppOpenedAsync()
		{
			return null;
		}

		public static Task TrackEventAsync(string name)
		{
			return null;
		}

		public static Task TrackEventAsync(string name, IDictionary<string, string> dimensions)
		{
			return null;
		}

		private static Task TrackAppOpenedWithPushHashAsync(string pushHash = null)
		{
			return null;
		}
	}
}
