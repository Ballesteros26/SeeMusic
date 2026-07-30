using Parse.Core.Internal;

namespace Parse.Push.Internal
{
	public class ParsePushPlugins : IParsePushPlugins
	{
		private static readonly object instanceMutex;

		private static IParsePushPlugins instance;

		private readonly object mutex;

		private IParseCorePlugins corePlugins;

		private IParsePushChannelsController pushChannelsController;

		private IParsePushController pushController;

		private IParseCurrentInstallationController currentInstallationController;

		private IDeviceInfoController deviceInfoController;

		public static IParsePushPlugins Instance => null;

		public IParseCorePlugins CorePlugins => null;

		public IParsePushChannelsController PushChannelsController => null;

		public IParsePushController PushController => null;

		public IParseCurrentInstallationController CurrentInstallationController => null;

		public IDeviceInfoController DeviceInfoController => null;
	}
}
