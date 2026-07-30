using System.Globalization;
using System.Reflection;

namespace System.Resources
{
	internal class ManifestBasedResourceGroveler : IResourceGroveler
	{
		private ResourceManager.ResourceManagerMediator _mediator;

		public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
		}

		internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
		{
			return null;
		}

		private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation)
		{
			return false;
		}
	}
}
