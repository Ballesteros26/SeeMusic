using System.Collections.Generic;

namespace Parse.Common.Internal
{
	public class ParseModuleController
	{
		private static readonly ParseModuleController instance;

		private readonly object mutex;

		private readonly List<IParseModule> modules;

		private bool isParseInitialized;

		public static ParseModuleController Instance => null;

		public void RegisterModule(IParseModule module)
		{
		}

		public void ScanForModules()
		{
		}

		public void Reset()
		{
		}

		public void ParseDidInitialize()
		{
		}
	}
}
