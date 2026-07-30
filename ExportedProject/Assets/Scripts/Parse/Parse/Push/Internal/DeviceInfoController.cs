using System.Threading.Tasks;

namespace Parse.Push.Internal
{
	public class DeviceInfoController : IDeviceInfoController
	{
		public string DeviceType { get; }

		public string DeviceTimeZone => null;

		public string AppBuildVersion { get; }

		public string AppIdentifier => null;

		public string AppName { get; }

		public Task ExecuteParseInstallationSaveHookAsync(ParseInstallation installation)
		{
			return null;
		}
	}
}
