using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	public class ParseCorePlugins : IParseCorePlugins
	{
		private static readonly object instanceMutex;

		private static IParseCorePlugins instance;

		private readonly object mutex;

		private IHttpClient httpClient;

		private IParseCommandRunner commandRunner;

		private IStorageController storageController;

		private IParseCloudCodeController cloudCodeController;

		private IParseConfigController configController;

		private IParseFileController fileController;

		private IParseObjectController objectController;

		private IParseQueryController queryController;

		private IParseSessionController sessionController;

		private IParseUserController userController;

		private IObjectSubclassingController subclassingController;

		private IParseCurrentUserController currentUserController;

		private IInstallationIdController installationIdController;

		public static IParseCorePlugins Instance => null;

		public IHttpClient HttpClient => null;

		public IParseCommandRunner CommandRunner => null;

		public IStorageController StorageController => null;

		public IParseCloudCodeController CloudCodeController => null;

		public IParseFileController FileController => null;

		public IParseConfigController ConfigController => null;

		public IParseObjectController ObjectController => null;

		public IParseQueryController QueryController => null;

		public IParseSessionController SessionController => null;

		public IParseUserController UserController => null;

		public IParseCurrentUserController CurrentUserController => null;

		public IObjectSubclassingController SubclassingController => null;

		public IInstallationIdController InstallationIdController => null;
	}
}
