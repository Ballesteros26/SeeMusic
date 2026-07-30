using Parse.Core.Internal;

namespace Parse.Analytics.Internal
{
	public class ParseAnalyticsPlugins : IParseAnalyticsPlugins
	{
		private static readonly object instanceMutex;

		private static IParseAnalyticsPlugins instance;

		private readonly object mutex;

		private IParseCorePlugins corePlugins;

		private IParseAnalyticsController analyticsController;

		public static IParseAnalyticsPlugins Instance => null;

		public IParseCorePlugins CorePlugins => null;

		public IParseAnalyticsController AnalyticsController => null;
	}
}
