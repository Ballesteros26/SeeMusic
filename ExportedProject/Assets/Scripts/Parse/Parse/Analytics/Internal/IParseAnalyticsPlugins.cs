using Parse.Core.Internal;

namespace Parse.Analytics.Internal
{
	public interface IParseAnalyticsPlugins
	{
		IParseCorePlugins CorePlugins { get; }

		IParseAnalyticsController AnalyticsController { get; }
	}
}
