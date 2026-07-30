namespace Parse.Push.Internal
{
	public interface IParsePushPlugins
	{
		IParsePushChannelsController PushChannelsController { get; }

		IParsePushController PushController { get; }

		IParseCurrentInstallationController CurrentInstallationController { get; }

		IDeviceInfoController DeviceInfoController { get; }
	}
}
